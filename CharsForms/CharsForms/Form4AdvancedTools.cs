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
    public partial class Form4AdvancedTools : Form
    {
        public Form4AdvancedTools()
        {
            InitializeComponent();
        }

        private void Form4AdvancedTools_Load(object sender, EventArgs e)
        {
            TreeNode treeNode = treeView1.Nodes.Add("Name");
            TreeNode tn1 = new TreeNode("ZWT");
            TreeNode tn2 = new TreeNode("GLZ");
            TreeNode tn3 = new TreeNode("ZWM");
            treeNode.Nodes.Add(tn1);
            treeNode.Nodes.Add(tn2);
            treeNode.Nodes.Add(tn3);

            //dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePickerTextBox.Text = dateTimePicker1.Text;
            dateTimePickerTextBox.Text = dateTimePicker1.Value.Year.ToString();
            dateTimePickerTextBox.Text = dateTimePicker1.Value.Month.ToString();
            dateTimePickerTextBox.Text = dateTimePicker1.Value.Day.ToString();


            textBox1.Text = monthCalendar1.TodayDate.ToString();

            timer1.Interval = 1000;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewLabel.Text = "Selected Node: " + e.Node.Text;
        }

        private void treeViewRemove_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Name")
            {
                MessageBox.Show("Please select the child node");

            }
            else
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }

        //TitleBackColor, TitleForeColor, TrailingForeColor, SHowWeekNumbers, CalendarDimensions, UpdateBoldedDates
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar1.SelectionStart.ToString();
            textBox3.Text = monthCalendar1.SelectionEnd.ToString();

        }

        private int a, b, c;
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "");
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
                a = 1;
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "not null");
            }
            else
            {
                try
                {
                    int x = Int32.Parse(textBox5.Text);
                    errorProvider2.SetError(textBox5, "");
                    b = 1;
                }
                catch
                {
                    errorProvider2.SetError(textBox5, "Input a number");
                }

            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Text == "")
            {
                errorProvider3.SetError(textBox6, "not null");
            }
            else
            {
                errorProvider3.SetError(textBox6, "");
                c = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a + b + c == 3)
            {
                MessageBox.Show("Data saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        //How to use help doc? Click help button, Press F1
        private void helpBtn_Click(object sender, EventArgs e)
        {
            string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            string helpPath = folderPath + @"\Help.doc";
            helpProvider1.HelpNamespace = helpPath;
            MessageBox.Show(helpPath);
            helpProvider1.SetShowHelp(this, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTextBox.Text = DateTime.Now.ToString();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            if (timerButton.Text == "Start")
            {
                timer1.Enabled = true;
                timerButton.Text = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                timerButton.Text = "Start";
            }
        }

        private void progressBtn_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.PerformStep();
                progressTextBox.Text = "Progress:"+progressBar1.Value.ToString();
            }
        }
    }
}
