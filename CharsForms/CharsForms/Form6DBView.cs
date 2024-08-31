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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace CharsForms
{
    public partial class Form6DBView : Form
    {
        public Form6DBView()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        DataSet dataSet;
        SqlDataAdapter sda;
        int index = 0;
        private void Form6DBView_Load(object sender, EventArgs e)
        {

        }

        private void tableCellBtn_Click(object sender, EventArgs e)
        {
            string msg = String.Format("Row{0},column{1}", tableCellGridView.CurrentCell.RowIndex, tableCellGridView.CurrentCell.ColumnIndex);
            tableCellLbl.Text = "Selected Cell is " + msg;
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            string conStr = "server=查雯婷;database=zhadb;uid=zhawenting;pwd=";
            connection = new SqlConnection(conStr);
            dataSet = new DataSet();
            sda = new SqlDataAdapter("select * from dbuser", connection);
            sda.Fill(dataSet, "dbuser");
            tableCellGridView.DataSource = dataSet.Tables[0];
            //tableCellGridView.RowHeadersVisible = false;
            for (int i = 0; i < tableCellGridView.ColumnCount; i++)
            {
                tableCellGridView.Columns[i].Width = 81;
            }

            loadDataBtn.Enabled = false;
            tableCellGridView.Columns[0].ReadOnly = true;
        }

        private void editDataBtn_Click(object sender, EventArgs e)
        {
            if (dbUpdate())
            {
                MessageBox.Show("Updated!");
            }
        }

        private DataTable dbConn(string strSql)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            this.sda = new SqlDataAdapter(strSql, connection);
            DataTable dtSelect = new DataTable();
            int rnt = this.sda.Fill(dtSelect);
            return dtSelect;
        }

        private Boolean dbUpdate()
        {
            tableCellGridView.ReadOnly = false;
            string strSql = "select * from dbuser";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbConn(strSql);
            DataTable dtDisplay = new DataTable();
            dtDisplay = (DataTable)this.tableCellGridView.DataSource;
            dtUpdate.ImportRow(dtDisplay.Rows[index]);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(this.sda);
            this.sda.Update(dtUpdate);
            dtUpdate.AcceptChanges();
            return true;
        }

        private void tableCellGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void testDataBtn_Click(object sender, EventArgs e)
        {

            styledDataGridView.ColumnCount = 4;
            styledDataGridView.ColumnHeadersVisible = true;

            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            dataGridViewCellStyle.BackColor = Color.Chartreuse;
            dataGridViewCellStyle.Font = new Font("Verdana", 11, FontStyle.Bold);
            styledDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            styledDataGridView.Columns[0].Name = "Number";
            styledDataGridView.Columns[1].Name = "Name";
            styledDataGridView.Columns[2].Name = "Bouns";
            styledDataGridView.Columns[3].Name = "Level";

            string[] row1 = new string[]
            {
                "001","A","1000","1"
            };
            string[] row2 = new string[]
           {
                "002","B","2000","2"
           };
            string[] row3 = new string[]
           {
                "003","C","3000","3"
           };
            string[] row4 = new string[]
           {
                "004","D","4000","4"
           };
            string[] row5 = new string[]
           {
                "005","E","5000","5"
           };
            object[] rows = new object[] { row1, row2, row3, row4, row5 };
            foreach (string[] row in rows)
            {
                styledDataGridView.Rows.Add(row);
            }

            styledDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            styledDataGridView.ReadOnly = true;
            styledDataGridView.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
        }

        private void linqQueryBtn_Click(object sender, EventArgs e)
        {
            string conStr = "server=查雯婷;database=zhadb;uid=zhawenting;pwd=";
            SqlConnection connection = new SqlConnection(conStr);
            DataSet dataSet = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbuser", connection);
            sda.Fill(dataSet, "dbuser");
            var query = from salary in dataSet.Tables["dbuser"].AsEnumerable()
                        select salary;
            DataTable dataTable = query.CopyToDataTable<DataRow>();
            linqDataGridView.DataSource = dataTable;
        }

        string xmlFile = "Employee.xml.txt";
        string strID = "";

        private void insertXmlBtn_Click(object sender, EventArgs e)
        {
            //string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            //string path = folderPath + @"\Employee.xml.txt";
            XElement xElement = XElement.Load(xmlFile);
            IEnumerable<XElement> elements = from element in xElement.Elements("Employee")
                                             select element;
            string str = (Convert.ToInt32(elements.Max(element => element.Attribute("ID").Value)) + 1).ToString("000");
            XElement employee = new XElement(
                "Employee", new XAttribute("ID", str),
                new XElement("Name", linqXmlNameTextBox.Text),
                new XElement("Gender", linqXmlGenderComboBox1.Text),
                new XElement("Salary", linqXmlSalaryTextBox.Text)
                );
            xElement.Add(employee);
            xElement.Save(xmlFile);
            getXmlInfo();
        }


        private void editXmlBtn_Click(object sender, EventArgs e)
        {
            if (strID != "")
            {
                //string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
                //string path = folderPath + @"\Employee.xml.txt";
                XElement xElement = XElement.Load(xmlFile);
                IEnumerable<XElement> elements = from element in xElement.Elements("Employee")
                                                 where element.Attribute("ID").Value == strID
                                                 select element;
                if (elements.Count() > 0)
                {
                    XElement newXElement = elements.First();
                    newXElement.SetAttributeValue("ID", strID);
                    newXElement.ReplaceNodes(
                          new XElement("Name", linqXmlNameTextBox.Text),
                          new XElement("Gender", linqXmlGenderComboBox1.Text),
                          new XElement("Salary", linqXmlSalaryTextBox.Text)
                    );
                }
                xElement.Save(xmlFile);
                getXmlInfo();
            }

        }

        private void delXmlBtn_Click(object sender, EventArgs e)
        {
            if (strID != "")
            {
                //string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
                //string path = folderPath + @"\Employee.xml.txt";
                XElement xElement = XElement.Load(xmlFile);
                IEnumerable<XElement> elements = from element in xElement.Elements("Employee")
                                                 where element.Attribute("ID").Value == strID
                                                 select element;
                if (elements.Count() > 0)
                {
                    elements.First().Remove();
                }
                xElement.Save(xmlFile);
                getXmlInfo();
            }
        }

        private void getXmlInfo()
        {
            DataSet dataSet = new DataSet();

            //string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            //string path = folderPath + @"\Employee.xml.txt";
            dataSet.ReadXml(xmlFile);
            xmlLinqGridView.DataSource = dataSet.Tables[0];
        }

        private void xmlLinqGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //string folderPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            //string path = folderPath + @"\Employee.xml.txt";
            strID = xmlLinqGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            XElement xElement = XElement.Load(xmlFile);
            IEnumerable<XElement> element = from PInfo in xElement.Elements("Employee")
                                           where PInfo.Attribute("ID").Value == strID
                                           select PInfo;
            foreach (XElement elem in element)
            {
                linqXmlNameTextBox.Text = elem.Element("Name").Value;
                //linqXmlGenderComboBox1.SelectedItem = elem.Element("Gender").Value;
                linqXmlGenderComboBox1.Text = elem.Element("Gender").Value;
                linqXmlSalaryTextBox.Text = elem.Element("Salary").Value;
            }
        }

        private void linqXmlCheckBtn_Click(object sender, EventArgs e)
        {
            getXmlInfo();
        }


    }
}
