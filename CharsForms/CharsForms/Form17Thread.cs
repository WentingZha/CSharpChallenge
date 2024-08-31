using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharsForms
{

    public partial class Form17Thread : Form
    {

        public Form17Thread()
        {
            InitializeComponent();
        }

        private void Form17Thread_Load(object sender, EventArgs e)
        {

        }


        private void createThreadBtn_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            Thread thread = new Thread(new ThreadStart(() => MessageBox.Show("Start a new thread")));
            thread.Start();
            str = "Thread ID: " + thread.ManagedThreadId;
            str += "\nThread Name: " + thread.Name;
            str += "\nThread Status: " + thread.ThreadState.ToString();
            str += "\nThread Priority: " + thread.Priority.ToString();
            str += "\nIs Background Thread: " + thread.IsBackground;

            lblThreadStatus.Text = "Thread Status: " + thread.ThreadState.ToString();
            Thread.Sleep(1000);

            thread.Interrupt();
            thread.Join();//This thread cannot be called again
            MessageBox.Show("Thread stopped");
            rtbThreadProperty.Text = str;
        }

        Image image;
        private void openPictureBtn_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "*.jpg,*.jpeg,*.bmp|*.jpg;*.jpeg;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                BackgroundImage = image;
            }
        }

        //Not implemented
        private void animateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = (Bitmap)BackgroundImage.Clone();
                int intWidth = bitmap.Width;
                int intHeight = bitmap.Height / 20;
                Graphics graphics = CreateGraphics();
                graphics.Clear(Color.Violet);
                Point[] point = new Point[30];
                for (int i = 0; i < 30; i++)
                {
                    point[i].X = 0;
                    point[i].Y = i * intHeight;
                }
                Bitmap bitmap1 = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < intWidth; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        for (int k = 0; k < intHeight; j++)
                        {
                            bitmap.SetPixel(point[j].X + k, point[j].Y + k, bitmap.GetPixel(point[j].X + k, point[j].Y + i));
                        }
                    }
                }
                Refresh();
                BackgroundImage = image;
                System.Threading.Thread.Sleep(1000);
            }
            catch { }
        }

        string strConn = "server=ZhaWenTing;database=zhadb;uid=zhawenting;pwd=";
        SqlConnection sqlConn = null;
        Thread threadConn = null;
        Thread threadInsert = null;
        //
        private static long threadCount = 0;
        private static EventWaitHandle ewh;
        private static EventWaitHandle clearCount =
            new EventWaitHandle(false, EventResetMode.AutoReset);

        private void ThreadInsert()
        {

           // ewh = new EventWaitHandle(false, EventResetMode.ManualReset);
           // ewh.WaitOne();
            sqlConn = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO DBUSER(NAME,BONUS,LEVEL) VALUES('JLL,1000,4)",sqlConn);
            sqlConn.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
            MessageBox.Show("Inserted");
         
           // ewh.Set();
        }

        private void ThreadConn()
        {
            richTextBox1.Text = "";
            //ewh = new EventWaitHandle(false, EventResetMode.AutoReset);

            sqlConn = new SqlConnection(strConn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbuser", sqlConn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                richTextBox1.Text += "\n" + dataSet.Tables[0].Rows[i][0].ToString() + " " + dataSet.Tables[0].Rows[i][1].ToString();
            
            }
          
        }

        private void connThreadBtn_Click(object sender, EventArgs e)
        {
            threadConn = new Thread(new ThreadStart(ThreadConn));
            threadConn.Start();
        }

        [Obsolete]
        private void insertThreadBtn_Click(object sender, EventArgs e)
        {

            threadConn.Suspend();
            threadInsert = new Thread(new ThreadStart(ThreadInsert));
            threadInsert.Start();
            threadConn.Resume();
        }
    }
}
