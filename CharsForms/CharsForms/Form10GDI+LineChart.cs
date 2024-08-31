using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharsForms
{
    public partial class Form10GDI_Graphic : Form
    {
        public Form10GDI_Graphic()
        {
            InitializeComponent();
        }

      
        private void Form10GDI_Graphic_Paint(object sender, PaintEventArgs e)
        {
            string[] month = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            float[] d = new float[12] { 20.5F, 60, 10.8F, 15.6F, 30, 70.9F, 50.3F, 30.7F, 70, 50.4F, 30.8F, 20 };
            //Initialize
            Bitmap bMap = new Bitmap(500, 500);
            Graphics gph = Graphics.FromImage(bMap);
            gph.Clear(Color.White);
            PointF cPt = new PointF(40, 420);//Center
            PointF[] xPt = new PointF[3] { new PointF(cPt.Y + 15, cPt.Y), new PointF(cPt.Y, cPt.Y - 8), new PointF(cPt.Y, cPt.Y + 8) };//X axis triangle
            PointF[] yPt = new PointF[3] { new PointF(cPt.X, cPt.X - 15), new PointF(cPt.X - 8, cPt.X), new PointF(cPt.X + 8, cPt.X) };//Y axis triangle
            gph.DrawString("Product Cascadia", new Font("Cascadia", 14), Brushes.Black, new PointF(cPt.X + 60, cPt.X));//The title of the chart
            //X Axis
            gph.DrawLine(Pens.Black, cPt.X, cPt.Y, cPt.Y, cPt.Y);
            gph.DrawPolygon(Pens.Black, xPt);
            gph.FillPolygon(new SolidBrush(Color.Black), xPt);
            gph.DrawString("Month", new Font("Cascadia", 12), Brushes.Black, new PointF(cPt.Y + 10, cPt.Y + 10));
            //Y Axis
            gph.DrawLine(Pens.Black, cPt.X, cPt.Y, cPt.X, cPt.X);
            gph.DrawPolygon(Pens.Black, yPt);
            gph.FillPolygon(new SolidBrush(Color.Black), yPt);
            gph.DrawString("Thousand", new Font("Cascadia", 12), Brushes.Black, new PointF(0, 7));
            for (int i = 1; i <= 12; i++)
            {
                //Graduation of Y axis
                if (i < 11)
                {
                    gph.DrawString((i * 10).ToString(), new Font("Cascadia", 11), Brushes.Black, new PointF(cPt.X - 30, cPt.Y - i * 30 - 6));
                    gph.DrawLine(Pens.Black, cPt.X - 3, cPt.Y - i * 30, cPt.X, cPt.Y - i * 30);
                }
                //Graduation of X axis
                gph.DrawString(month[i - 1], new Font("Cascadia", 11), Brushes.Black, new PointF(cPt.X + i * 30 - 5, cPt.Y + 5));
                //gph.DrawString(month[i - 1].Substring(1, 1), new Font("Cascadia", 11), Brushes.Black, new PointF(cPt.X + i * 30 - 5, cPt.Y + 20));
                if (month[i - 1].Length > 2) gph.DrawString(month[i - 1].Substring(2, 1), new Font("Cascadia", 11), Brushes.Black, new PointF(cPt.X + i * 30 - 5, cPt.Y + 35));
                //Draw points
                gph.DrawEllipse(Pens.Black, cPt.X + i * 30 - 1.5F, cPt.Y - d[i - 1] * 3 - 1.5F, 3, 3);
                gph.FillEllipse(new SolidBrush(Color.Black), cPt.X + i * 30 - 1.5F, cPt.Y - d[i - 1] * 3 - 1.5F, 3, 3);
                //Set values
                gph.DrawString(d[i - 1].ToString(), new Font("Cascadia", 11), Brushes.Black, new PointF(cPt.X + i * 30, cPt.Y - d[i - 1] * 3));
                //Draw lines
                if (i > 1) gph.DrawLine(Pens.Red, cPt.X + (i - 1) * 30, cPt.Y - d[i - 2] * 3, cPt.X + i * 30, cPt.Y - d[i - 1] * 3);
            }
            pictureBox1.Image = bMap;
        }
    }
}
