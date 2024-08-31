using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharsForms
{
    public partial class Form12GDI_BarChart : Form
    {
        public Form12GDI_BarChart()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon;

        private void Form12GDI_BarChart_Load(object sender, EventArgs e)
        {
            string P_str_sum = "SELECT * FROM tb_01";
            sqlcon = new SqlConnection("server=查雯婷;database=db_CSharp;uid=zhawenting;pwd=");
            SqlDataAdapter myda = new SqlDataAdapter(P_str_sum, sqlcon);
            DataSet myds = new DataSet();
            myda.Fill(myds);
            comboBox1.DataSource = myds.Tables[0].DefaultView;
            comboBox1.DisplayMember = "yearID";
        }

        private int sumNum(int P_int_year)
        {
            string P_str_sum = "SELECT SUM(month1+month2+month3+month4+month5+month6+month7+month8+month9+month10+month11+month12) AS number FROM tb_01 WHERE yearID=" + P_int_year + "";
            SqlDataAdapter myda = new SqlDataAdapter(P_str_sum, sqlcon);
            DataSet myds = new DataSet();
            myda.Fill(myds);
            return Convert.ToInt32(myds.Tables[0].Rows[0][0].ToString());
        }
        private void CreateImage(int P_int_year)
        {
            int height = 400, width = 600;
            Bitmap image = new Bitmap(width, height);
            //Create Graphics object
            Graphics graphics = Graphics.FromImage(image);
            try
            {
                //Clear background color
                graphics.Clear(Color.White);
                Font font = new Font("Arial", 9, FontStyle.Regular);
                Font font1 = new Font("Cascadia", 20, FontStyle.Regular);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Blue, 1.2f, true);
                graphics.FillRectangle(Brushes.WhiteSmoke, 0, 0, width, height);
                Brush brush1 = new SolidBrush(Color.Blue);
                graphics.DrawString("" + P_int_year + " Monthly Sales", font1, brush1, new PointF(150, 30));
                //Draw the border
                graphics.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);
                Pen mypen = new Pen(brush, 1);
                //Draw the honrizontal line
                int x = 100;//106
                for (int i = 0; i < 11; i++)
                {
                    graphics.DrawLine(mypen, x, 80, x, 366);
                    x = x + 40;
                }
                Pen mypen1 = new Pen(Color.Blue, 2);
                graphics.DrawLine(mypen1, x - 480, 80, x - 480, 366);
                //Draw the vertical line
                int y = 127;//110//130
                for (int i = 0; i < 10; i++)
                {
                    graphics.DrawLine(mypen, 60, y, 540, y);

                    y = y + 24;
                }
                graphics.DrawLine(mypen1, 60, y, 540, y);
                //x axis
                String[] n = {"  1", "  2", "  3", "  4", "  5", "  6", "  7",
                     "  8", "  9", "  10", "11", "12"};
                x = 65;
                for (int i = 0; i < 12; i++)
                {
                    graphics.DrawString(n[i].ToString(), font, Brushes.Red, x, 374); //Set the words and output position
                    x = x + 40;
                }
                //y axis 
                String[] m = {"100%", " 90%", " 80%", " 70%", " 60%", " 50%", " 40%", " 30%",
                     " 20%", " 10%", "  0%"};
                y = 120;//100
                for (int i = 0; i < 11; i++)
                {
                    graphics.DrawString(m[i].ToString(), font, Brushes.Red, 25, y);//Set the words and output position
                    y = y + 24;
                }
                int[] Count = new int[12];
                string P_str_yearID = "SELECT * FROM tb_01 WHERE yearID=" + P_int_year + "";
                SqlDataAdapter myda = new SqlDataAdapter(P_str_yearID, sqlcon);
                DataSet myds = new DataSet();
                myda.Fill(myds);
                int P_int_num = sumNum(P_int_year);
                for (int j = 0; j < 12; j++)
                {
                    Count[j] = Convert.ToInt32(myds.Tables[0].Rows[0][j + 1].ToString()) * 100 / P_int_num;
                }
                //Bar chart 
                x = 70;
                for (int i = 0; i < 12; i++)
                {
                    SolidBrush mybrush = new SolidBrush(Color.Red);
                    graphics.FillRectangle(mybrush, x, 366 - Count[i] * 14 / 10, 20, Count[i] * 14 / 10);
                    x = x + 40;
                }
                System.IO.MemoryStream MStream = new System.IO.MemoryStream();
                image.Save(MStream, System.Drawing.Imaging.ImageFormat.Gif);
                Bitmap bmap = new Bitmap(image);
                pictureBox1.Image = bmap;
            }
            finally
            {
                graphics.Dispose();
                image.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                CreateImage(Convert.ToInt32(comboBox1.Text)); //Call the painting function
            }
            else
            {
                MessageBox.Show("Please select the sales year");
            }
        }

    }
}
