using System;
using System.Collections;
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
    public partial class Form8SyntaxAdvanced : Form
    {
        public Form8SyntaxAdvanced()
        {
            InitializeComponent();
        }

        private void Form8SyntaxAdvanced_Load(object sender, EventArgs e)
        {
            //Enumerator
            Family family = new Family();
            foreach (string str in family)
            {
                enumeratorRichTB.Text += str + "\n";
            }

            //Partial Class
            partialClassCB.SelectedIndex = 0;
            partialClassCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public class Family : System.Collections.IEnumerable
        {
            string[] myFamily = { "ZWT", "GLZ", "ZWM", "HWH" };
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < myFamily.Length; i++)
                    yield return myFamily[i];
            }
        }


        //partial class
        partial class Account
        {
            public int add(int a, int b)
            {
                return a + b;
            }
        }

        partial class Account
        {
            public int multiply(int a, int b)
            {
                return a * b;
            }
        }

        partial class Account
        {
            public int substract(int a, int b)
            {
                return a - b;
            }
        }

        partial class Account
        {
            public int divide(int a, int b)
            {
                return a / b;
            }
        }

        private void partialClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account();
                int num1 = int.Parse(partialClassTb1.Text.Trim());
                int num2 = int.Parse(partialClassTb2.Text.Trim());
                string str = partialClassCB.Text;
                switch (str)
                {
                    case "+": partialClassTb3.Text = account.add(num1, num2).ToString(); break;
                    case "-": partialClassTb3.Text = account.substract(num1, num2).ToString(); break;
                    case "*": partialClassTb3.Text = account.multiply(num1, num2).ToString(); break;
                    case "/": partialClassTb3.Text = account.divide(num1, num2).ToString(); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

            //Generic interface
    public interface IGenericInterface<T>
    {
        T CreateInstance();
    }
    }
}
