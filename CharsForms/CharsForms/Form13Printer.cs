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
    public partial class Form13Printer : Form
    {
        public Form13Printer()
        {
            InitializeComponent();
        }

        private void pageSetupBtn_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            //Set margins
            pageSetupDialog1.AllowMargins = true;
            pageSetupDialog1.AllowOrientation = true;
            pageSetupDialog1.AllowPaper = true;
            pageSetupDialog1.AllowPrinter = true;
            pageSetupDialog1.ShowDialog();
        }

        private void printDialogBtn_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.AllowPrintToFile = true;
            printDialog1.AllowCurrentPage = true;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ABC", new Font("Cascadia", 15), Brushes.Blue, 350, 80);
            e.Graphics.DrawLine(new Pen(Color.Blue, (float)3.00), 100, 185, 720, 185);
            e.Graphics.DrawString("Many chars Many chars Many chars Many chars", new Font("Cascadia", 11), Brushes.Violet, 110, 195);
            e.Graphics.DrawString("Line2: Many chars Many chars Many chars Many chars", new Font("Cascadia", 11), Brushes.Violet, 110, 220);
            e.Graphics.DrawString("Line3: Many chars Many chars Many chars Many chars", new Font("Cascadia", 11), Brushes.Violet, 110, 245);
            e.Graphics.DrawString("Line4: Many chars Many chars Many chars Many chars", new Font("Cascadia", 11), Brushes.Violet, 110, 270);
            e.Graphics.DrawLine(new Pen(Color.Violet, (float)3.00), 100, 300, 720, 300);
        }

        private void browseTextBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ready to browse the print?", "Preview", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                printPreviewDialog1.UseAntiAlias = true;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                //Skip preview to print the text
                printDocument1.Print();
            }
        }

        private void Form13Printer_Load(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument2;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string str = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            str += @"\1.jpg";
            e.Graphics.DrawImage(Image.FromFile(str), 10, 10, 607, 452);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            //printDialog2.ShowDialog();
            printPreviewDialog2.Document = printDocument3;
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
              label1.Text, new Font("Cascadia", 10, FontStyle.Regular), Brushes.Black, 0, 0);
            e.Graphics.DrawString(
                printNameTb.Text, new Font("Cascadia", 10, FontStyle.Regular), Brushes.Black, 60, 0);
            e.Graphics.DrawString(
                label2.Text, new Font("Cascadia", 10, FontStyle.Regular), Brushes.Black, 0, 20);
            e.Graphics.DrawString(
                printDeptTb.Text, new Font("Cascadia", 10, FontStyle.Regular), Brushes.Black, 60, 20);
            e.Graphics.DrawString(
                label3.Text, new Font("Cascadia", 10, FontStyle.Regular), Brushes.Black, 0, 40);
            e.Graphics.DrawString(
                printPositionTb.Text, new Font("Cascadia", 10, FontStyle.Regular), Brushes.Black, 60, 40);
        }
    }
}
