using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CharsForms
{
    public partial class Form9IOStream : Form
    {
        public Form9IOStream()
        {
            InitializeComponent();
        }

        private void createFileBt_Click(object sender, EventArgs e)
        {
            if (createFileTB.Text == string.Empty)
            {
                MessageBox.Show("Input the file name");
            }
            else
            {
                if (File.Exists(createFileTB.Text))
                {
                    MessageBox.Show("File exists");
                }
                else
                {
                    File.CreateText(createFileTB.Text);
                    MessageBox.Show("Done!");
                }

            }
        }

        private void createFolderBtn_Click(object sender, EventArgs e)
        {
            if (createFolderTB.Text == string.Empty)
            {
                MessageBox.Show("Input the folder name");
            }
            else
            {
                if (File.Exists(createFolderTB.Text))
                {
                    MessageBox.Show("folder exists");
                }
                else
                {
                    Directory.CreateDirectory(createFolderTB.Text);
                    MessageBox.Show("Done!");
                }

                /*
                DirectoryInfo directoryInfo = new DirectoryInfo(createFolderTB.Text);
                if (directoryInfo.Exists)
                {
                    MessageBox.Show("folder exists");
                }
                else
                {
                    directoryInfo.Create();
                    MessageBox.Show("Done!");
                }
                */

            }
        }

        private void createFilePathNameBtn_Click(object sender, EventArgs e)
        {
            if (createFilePathNameTb.Text == string.Empty)
            {
                MessageBox.Show("Input the file path and name");
            }
            else
            {
                FileInfo fileInfo = new FileInfo(createFilePathNameTb.Text);
                if (fileInfo.Exists)
                {
                    MessageBox.Show("File exists");
                }
                else
                {
                    fileInfo.Create();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileTb.Text = openFileDialog1.FileName;
                FileInfo fileInfo = new FileInfo(openFileTb.Text);
                string createTime, lastAccessTime, LastWriteTime, name, fullName, dirName, isReadOnly;
                long lgLength;
                createTime = fileInfo.CreationTime.ToShortDateString();
                lastAccessTime = fileInfo.LastAccessTime.ToShortDateString();
                LastWriteTime = fileInfo.LastWriteTime.ToShortDateString();
                name = fileInfo.Name;
                fullName = fileInfo.FullName;
                dirName = fileInfo.DirectoryName;
                isReadOnly = fileInfo.IsReadOnly.ToString();
                lgLength = fileInfo.Length;
                MessageBox.Show("File info:\nCreate time:" + createTime + "\nlastAccessTime:" + lastAccessTime + "\nLastWriteTime:" + LastWriteTime
                    + "\nname:" + name + "\nfullName:" + fullName + "\ndirName:" + dirName + "\nisReadOnly:" + isReadOnly + "\nlgLength:" + lgLength);

            }
        }

        //ListView: set details, set columns
        private void browseFolderBtn_Click(object sender, EventArgs e)
        {
            browserFolderListView.Items.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                browseFolderTb.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(browseFolderTb.Text);
                FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos();
                foreach (FileSystemInfo fsinfo in fileSystemInfos)
                {
                    if (fsinfo is DirectoryInfo)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(fsinfo.FullName);
                        browserFolderListView.Items.Add(dirInfo.Name);
                        browserFolderListView.Items[browserFolderListView.Items.Count - 1].SubItems.Add(dirInfo.FullName);
                        browserFolderListView.Items[browserFolderListView.Items.Count - 1].SubItems.Add("");
                        browserFolderListView.Items[browserFolderListView.Items.Count - 1].SubItems.Add(dirInfo.CreationTime.ToShortDateString());

                    }
                    else
                    {
                        FileInfo fileInfo = new FileInfo(fsinfo.FullName);
                        browserFolderListView.Items.Add(fileInfo.Name);
                        browserFolderListView.Items[browserFolderListView.Items.Count - 1].SubItems.Add(fileInfo.FullName);
                        browserFolderListView.Items[browserFolderListView.Items.Count - 1].SubItems.Add(fileInfo.Length.ToString());
                        browserFolderListView.Items[browserFolderListView.Items.Count - 1].SubItems.Add(fileInfo.CreationTime.ToShortDateString());
                    }
                }
            }
        }

        //=======read or write .txt============
        private void readBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileWriterTb.Text = string.Empty;
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                fileWriterTb.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {


            if (fileWriterTb.Text == string.Empty)
            {
                MessageBox.Show("Text should not be empty.");
            }
            else
            {
                saveFileDialog1.Filter = "Text(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName, true);
                    streamWriter.WriteLine(fileWriterTb.Text);
                    streamWriter.Close();
                    fileWriterTb.Text = string.Empty;
                }
            }
        }

        //===========Birnary files============
        private void binaryReadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary(*.dat)|*.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                binaryIOTextBox.Text = string.Empty;
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                if (binaryReader.PeekChar() != -1)
                {
                    binaryIOTextBox.Text = binaryReader.ReadString();
                }
                binaryReader.Close();
                fileStream.Close();

            }
        }
        private void binaryWriteBtn_Click(object sender, EventArgs e)
        {


            if (binaryIOTextBox.Text == string.Empty)
            {
                MessageBox.Show("Text should not be empty.");
            }
            else
            {
                saveFileDialog1.Filter = "Binary(*.dat)|*.dat";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write(binaryIOTextBox.Text);
                    binaryWriter.Close();
                    binaryIOTextBox.Text = string.Empty;
                }
            }
        }


        //===========Copy Files===============
        private void copyFilesBtn1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            copyFilesTB1.Text = folderBrowserDialog1.SelectedPath;
            DirectoryInfo directoryInfo = new DirectoryInfo(copyFilesTB1.Text);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            for (int i = 0; i < fileInfos.Length; i++)
            {
                copyFilesListBox.Items.Add(fileInfos[i]);
            }
        }

        private void openFilesBtn2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            copyFilesTB2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void copyFilesBtn3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < copyFilesListBox.SelectedItems.Count; i++)
            {
                string path1 = Path.Combine(copyFilesTB1.Text, copyFilesListBox.SelectedItems[i].ToString());
                string path2 = Path.Combine(copyFilesTB2.Text, i + "_copy");
                File.Copy(path1, path2, true);

            }

            /*
             foreach (object o in copyFilesListBox.SelectedItems)
             {
                 string path1 = Path.Combine(copyFilesTB1.Text, o.ToString());
                 string path2 = Path.Combine(copyFilesTB2.Text, "copy_"+o.ToString());
                 File.Copy(path1, path2, true);
             }
             */
        }

        //============Extract Files==============
        private void extractFilesBtn1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(extractFilesTb.Text);
            for (int i = 0; i < files.Length; i++)
            {
                extractFilesTb2.Lines = files;
            }
        }

        private void extractFilesBtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void extractFilesBtnOpen_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            extractFilesTb.Text = folderBrowserDialog1.SelectedPath;
        }




        private void writeToBinaryBtn_Click(object sender, EventArgs e)
        {
            byte[] text = Encoding.Default.GetBytes(writeToMemoryTb1.Text);
            MemoryStream memoryStream = new MemoryStream(100);
            memoryStream.Write(text, 0, text.Length);
            writeToMemoryTb2.Text = "Capacity: "+memoryStream.Capacity.ToString()
                +" Length:"+memoryStream.Length.ToString()+" Position:"+memoryStream.Position.ToString();
            memoryStream.Seek(0, SeekOrigin.Begin);
            byte[] byteArray = new byte[memoryStream.Length];
            int count = memoryStream.Read(byteArray, 0, (int)memoryStream.Length - 1);

            while (count < memoryStream.Length)
            {
                byteArray[count++] = Convert.ToByte(memoryStream.ReadByte());
            }
            char[] charArray = new char[Encoding.Default.GetCharCount(byteArray, 0, count)];
            Encoding.Default.GetChars(byteArray, 0, count, charArray, 0);
            for (int i = 0; i < charArray.Length; i++)
            {
                writeToMemoryTb3.Text += charArray[i].ToString();
            }
        }


    }
}
