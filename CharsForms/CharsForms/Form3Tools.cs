using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CharsForms
{
    public partial class Form3Tools : Form
    {
        public Form3Tools()
        {
            InitializeComponent();

            richTextBox1.Text = "Welcome to http://www.google.com Google";
        }
        private void Form3Tools_Load(object sender, EventArgs e)
        {

            label1.Text = "CSharp";

            textBox1.Multiline = true;

            richTextBox1.Multiline = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Text = "Welcome to http://www.google.com Google";
            //Set a bullet signal at the start of each line
            richTextBox1.SelectionBullet = true;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("C#");
            comboBox1.Items.Add("Java");

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            numericUpDown1.Maximum = 15;
            numericUpDown1.Minimum = 1;

            //A simple search bar
            panel1.Visible = false;
            panelRichTextBox.Text = "Name:ZhaWenTing\nGender:Female\nAge:35";

            tabControl1.ImageList = imageList1;
            tabPage1.ImageIndex = 0;
            tabPage1.Text = "Tab1";
            tabPage2.ImageIndex = 0;
            tabPage2.Text = "Tab2";
            Button btn1 = new Button();
            btn1.Text = "New";
            tabPage1.Controls.Add(btn1);

            //Date time status strip
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();

            //Load ImageList
            //string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            //string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            //string path1 = folderPath + @"\1.JPG";
            //string path2 = folderPath + @"\2.JPG";
            //Image image1 = Image.FromFile(path1, true);
            //imageList1.Images.Add(image1);
            //Image image2 = Image.FromFile(path2, true);
            //imageList1.Images.Add(image2);
            //imageList1.ImageSize = new Size(200, 165);
            //pictureBox1.Width = 200;
            //pictureBox1.Height = 165;

            //imageList1.Images.RemoveAt(0);
            listView1.View = View.Tile;
            listView1.LargeImageList = imageList1;
            imageList1.Images.Add(Image.FromFile("1.jpg"));
            imageList1.Images.Add(Image.FromFile("2.jpg"));
            listView1.Groups.Add(new ListViewGroup("Family1", HorizontalAlignment.Left));
            listView1.Groups.Add(new ListViewGroup("Family2", HorizontalAlignment.Left));
            listView1.Items.Add("ZWT");
            listView1.Items.Add("HWH");
            listView1.Items.Add("GLZ");
            listView1.Items.Add("ZWM");

            listView1.Items[0].Group = listView1.Groups[0];
            listView1.Items[1].Group = listView1.Groups[0];
            listView1.Items[2].Group = listView1.Groups[1];
            listView1.Items[3].Group = listView1.Groups[1];

            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[2].ImageIndex = 0;
            listView1.Items[3].ImageIndex = 1;
            listView1.Items[2].Selected = true;
            listView1.TileSize = new Size(100, 50);
        }

        //Right click on the tool and set lock controls to make the tool fixed
        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new Point(20, 30);
            this.Controls.Add(comboBox);

            textBox1.Text = "Many chars Many chars Many chars Many chars Many chars Many chars Many chars ";
            textBox1.Height = 100;

            textBox1.SelectionStart = 5;
            textBox1.SelectionLength = 5;

            richTextBox1.SelectionFont = new Font("Cascadia", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = System.Drawing.Color.Blue;


        }

        //TextBox
        //1.PasswordChar: Plain text will be replaced
        //2.Set Multiline

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }


        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        //ComboBox
        //1.Set DropDownStyle
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("CheckBox is checked");
            }
            else
            {
                MessageBox.Show("CheckBox is unchecked");
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Radiobutton1 is selected");
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("Radiobutton2 is selected");
            }
        }


        //DecimalPlaces
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownLabel.Text = numericUpDown1.Value + "";
        }


        //HorizontalScrollbar
        //ScrollAlwaysVisible
        //SelectionMode
        private void listBoxInsertBtn_Click(object sender, EventArgs e)
        {
            if (listBoxTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please insert the data");
            }
            else
            {
                listBox1.Items.Add(listBoxTextBox.Text);
                listBoxTextBox.Text = "";
            }

        }


        private void listBoxDeleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose the item you want to delete");
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void panelBtn_Click(object sender, EventArgs e)
        {
            if (panelTextBox.Text == "")
            {
                MessageBox.Show("Please write your name:");
                panelTextBox.Focus();
            }
            else
            {
                if (panelTextBox.Text.Trim() == "ZWT")
                {
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("No result");
                    textBox1.Text = "";
                }
            }
        }

        //Set shortcut: Text- Open (&O)
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Image
        //TextImageRelation
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void statusStripBtn_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Step = 1;
            for (int i = 0; i < 99; i++)
            {
                toolStripProgressBar1.PerformStep();
            }

        }

        private void imageListBtn1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = imageList1.Images[0];
        }

        private void ImageListBtn2_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = imageList1.Images[1];
        }

        private void listViewBtn_Click(object sender, EventArgs e)
        {
            if (listViewTextBox.Text == "")
            {
                MessageBox.Show("Please input an item");
            }
            else
            {
                listView1.Items.Add(listViewTextBox.Text);
                listViewTextBox.Text = "";
            }
        }

        private void listViewRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the item");
            }
            else
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.SelectedItems.Clear();
            }

        }

        private void listViewClear_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No items in the list");
            }
            else
            {
                listView1.Items.Clear();
            }

        }
    }

}
