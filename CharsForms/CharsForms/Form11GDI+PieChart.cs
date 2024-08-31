using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharsForms
{
    public partial class Form11GDI_PieChart : Form
    {
        public Form11GDI_PieChart()
        {
            InitializeComponent();
        }

        private void Form11GDI_PieChart_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=查雯婷;database=db_CSharp;uid=zhawenting;pwd=");
            conn.Open();
            string str2 = "SELECT SUM(HEAD_COUNT) AS Number FROM tb_age";
            SqlCommand cmd = new SqlCommand(str2, conn);
            int Sum = Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_age", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //Total staff of age from 20 to 25
            int man20to25 = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
            //Total staff of age from 26 to 30
            int man26to30 = Convert.ToInt32(ds.Tables[0].Rows[1][2].ToString());
            //Total staff of age from 31 to 40
            int man31to40 = Convert.ToInt32(ds.Tables[0].Rows[2][2].ToString());
            //Create object of paint
            int width = 400, height = 450;
            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            try
            {
                //Clear backgroud color
                g.Clear(Color.White);
                Pen pen1 = new Pen(Color.Red);
                Brush brush1 = new SolidBrush(Color.PowderBlue);
                Brush brush2 = new SolidBrush(Color.Blue);
                Brush brush3 = new SolidBrush(Color.Wheat);
                Brush brush4 = new SolidBrush(Color.Orange);
                Font font1 = new Font("Courier New", 16, FontStyle.Bold);
                Font font2 = new Font("Courier New", 8);
                g.FillRectangle(brush1, 0, 0, width, height);    //Background 
                g.DrawString("Pie chart: Age of Staff", font1, brush2, new Point(80, 20));  //Title
                int piex = 100, piey = 60, piew = 200, pieh = 200;
                //The angle of pie that indicate staff aged from 20 to 25
                float angle1 = Convert.ToSingle((360 / Convert.ToSingle(Sum)) * Convert.ToSingle(man20to25));
                //The angle of pie that indicate staff aged from 26 to 30
                float angle2 = Convert.ToSingle((360 / Convert.ToSingle(Sum)) * Convert.ToSingle(man26to30));
                //The angle of pie that indicate staff aged from 31 to 40
                float angle3 = Convert.ToSingle((360 / Convert.ToSingle(Sum)) * Convert.ToSingle(man31to40));
                g.FillPie(brush2, piex, piey, piew, pieh, 0, angle1);       //proportion of staff aged from 20 to 25
                g.FillPie(brush3, piex, piey, piew, pieh, angle1, angle2);  //proportion of staff aged from 26 to 30
                g.FillPie(brush4, piex, piey, piew, pieh, angle1 + angle2, angle3);  //proportion of staff aged from 31 to 40
                //Draw marks
                g.DrawRectangle(pen1, 50, 300, 310, 130);  //Draw scales
                g.FillRectangle(brush2, 90, 320, 20, 10);  //Draw rectangles
                g.DrawString("Aged from 20 to 25: " + Convert.ToSingle(man20to25) * 100 / Convert.ToSingle(Sum) + "%", font2, brush2, 120, 320);
                g.FillRectangle(brush3, 90, 360, 20, 10);
                g.DrawString("Aged from 26 to 30: " + Convert.ToSingle(man26to30) * 100 / Convert.ToSingle(Sum) + "%", font2, brush2, 120, 360);
                g.FillRectangle(brush4, 90, 400, 20, 10);
                g.DrawString("Aged from 31 to 40: " + Convert.ToSingle(man31to40) * 100 / Convert.ToSingle(Sum) + "%", font2, brush2, 120, 400);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pictureBox1.Image = bitmap;
        }
    }
}
