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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CharsForms
{
    public partial class Form7Linq : Form
    {
        public Form7Linq()
        {
            InitializeComponent();
        }

        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileListView.Items.Clear();
                folderPathTb.Text = folderBrowserDialog1.SelectedPath;
                List<FileInfo> files = new List<FileInfo>();
                foreach (string strFile in Directory.GetFiles(folderPathTb.Text))
                {
                    files.Add(new FileInfo(strFile));
                }
                var values = from strFile in files
                             group strFile by strFile.Extension into FExten
                             orderby FExten.Key
                             select FExten;
                foreach (var value in values)
                {
                    foreach (var vFile in value)
                        fileListView.Items.Add(vFile.FullName);
                }

            }

        }

        private void fileListView_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(fileListView.SelectedItems[0].Text);
            string[] strAttribute = new string[] {
                file.Name,Convert.ToDouble(file.Length/1024).ToString(),file.Extension,
                file.CreationTime.ToString(),file.IsReadOnly.ToString(),file.LastWriteTime.ToString()
            };
            var values = from strFile in strAttribute
                         select new
                         {
                             Name = strAttribute[0].ToString(),
                             Size = strAttribute[1].ToString(),
                             Extension = strAttribute[2].ToString(),
                             CreateTime = strAttribute[3].ToString(),
                             ReadOnly = strAttribute[4].ToString(),
                             WriteTime = strAttribute[5].ToString(),
                         };
            foreach (var value in values)
            {
                fileNameTb.Text = value.Name;
                fileSizeTb.Text = value.Size;
                fileExtensionTb.Text = value.Extension;
                fileCreateTimeTn.Text = value.CreateTime;
                fileReadOnlyTb.Text = value.ReadOnly;
                fileLastEditTb.Text = value.WriteTime;
            }
        }

        #region
        string conStr = "server=查雯婷;database=zhadb;uid=zhawenting;pwd=";
        SqlConnection sqlConn;
        SqlDataAdapter sqlDa;
        DataSet dataSet;
        #endregion


        private void Form7Linq_Load(object sender, EventArgs e)
        {
           
        }

        private void ascSortBtn_Click(object sender, EventArgs e)
        {
            var query = from bonus in dataSet.Tables["dbuser"].AsEnumerable()
                        orderby bonus.Field<decimal>("bonus") ascending
                        select bonus;
            DataView dataView = query.AsDataView();
            linqSortGridView.DataSource= dataView;
        }

        private void desSortBtn_Click(object sender, EventArgs e)
        {
            var query = from bonus in dataSet.Tables["dbuser"].AsEnumerable()
                        orderby bonus.Field<decimal>("bonus") descending
                        select bonus;
            DataView dataView = query.AsDataView();
            linqSortGridView.DataSource = dataView;
        }

        private void top5Btn_Click(object sender, EventArgs e)
        {
            var query = from bonus in dataSet.Tables["dbuser"].AsEnumerable()
                        orderby bonus.Field<decimal>("bonus") descending
                        select bonus;
            var result = query.Take(5);
            DataTable dataTable = result.CopyToDataTable<DataRow>();
            linqSortGridView.DataSource = dataTable;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(conStr);
            sqlDa = new SqlDataAdapter("select * from dbuser", sqlConn);
            dataSet = new DataSet();
            sqlDa.Fill(dataSet, "dbuser");
            var query = from salary in dataSet.Tables["dbuser"].AsEnumerable()
                        select salary;
            DataTable table = query.CopyToDataTable();
            linqSortGridView.DataSource = table;
        }
    }
}
