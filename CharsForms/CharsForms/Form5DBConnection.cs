using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Xml;


namespace CharsForms
{
    public partial class Form5DBConnection : Form
    {
        public Form5DBConnection()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        DataSet ds;
        SqlDataAdapter adapter;

        private void Form5DBConnection_Load(object sender, EventArgs e)
        {

        }

        private void dbConnBtn_Click(object sender, EventArgs e)
        {
            if (dbConnTextBox.Text == "")
            {
                MessageBox.Show("Please input the database name");
            }
            else
            {
                try
                {
                    //database: default is master, custom is zhadb
                    string conStr = "server=查雯婷;database=" + dbConnTextBox.Text.Trim() + ";uid=zhawenting;pwd=";
                    connection = new SqlConnection(conStr);
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        {
                            richTextBox1.Text = "Database " + dbConnTextBox.Text + " is connected";

                        }
                    }
                    /*
                     * using (SqlConnection connection = new SqlConnection(conStr))
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        {
                            richTextBox1.Text = "Database " + dbConnTextBox.Text + " is connected";
                           
                        }
                    }
                    */
                }
                catch
                {
                    richTextBox1.Text = "Database connection failed";

                }

            }

        }

        private void connBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                string chars = "";
                connection.Close();
                if (connection.State == ConnectionState.Closed)
                {
                    chars = "Database connection is closed";
                }
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    chars = "Database connection is open";
                }
                richTextBox1.Text = chars;

            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }

        }

        private void connBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Dispose();
                connection.Open();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }

        private void dbConnCheckBtn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open || commandCheckTextBox.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM " + commandCheckTextBox.Text.Trim();
                cmd.CommandType = CommandType.Text;
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                commandCheckLabel.Text = "Data Count: " + i.ToString();
            }
        }

        private void commandUpdateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE " + commandCheckTextBox.Text.Trim() + " SET BONUS=5000 WHERE LEVEL>4";
            cmd.CommandType = CommandType.Text;
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            commandCheckLabel.Text = "Data Count: " + i.ToString();
        }

        private void commandReaderBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM " + commandCheckTextBox.Text.Trim();
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listView1.Items.Add(sdr[1].ToString());
            }

        }

        private void dataGridViewBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + commandCheckTextBox.Text.Trim(), connection);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            ds = new DataSet();
            adapter.Fill(ds, "CSharp");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataAdapterIDTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
            dataAdapterNameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            dataAdapterBonusTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
            dataAdapterLevelTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void dataAdapterEditBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["CSharp"];
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dt.Columns["id"];
            dt.PrimaryKey = keyColumns;
            adapter.FillSchema(dt, SchemaType.Mapped);
            DataRow dr = dt.Rows.Find(dataAdapterIDTextBox.Text);
            //DataRow[] drs =  dt.Select("[id]="+ dataAdapterIDTextBox.Text);
            //DataRow dr = drs[0];
            dr["id"] = dataAdapterIDTextBox.Text.Trim();
            dr["name"] = dataAdapterNameTextBox.Text.Trim();
            dr["bonus"] = dataAdapterBonusTextBox.Text.Trim();
            dr["level"] = dataAdapterLevelTextBox.Text.Trim();

            //SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            //adapter.Update(dt);
        }

        private void datasetBtn_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + commandCheckTextBox.Text.Trim(), connection);
            adapter.Fill(ds);
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM course", connection);
            adapter1.Fill(dataSet1);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter1);
            dataSet1.Merge(ds, true, MissingSchemaAction.AddWithKey);
            datasetDataView.DataSource = dataSet1.Tables[0];

        }

        //Connect, Load DataGrid, Copy DataSet
        private void copyDataSetBtn_Click(object sender, EventArgs e)
        {

            DataSet dataset1 = ds.Copy();
            copyGridView1.DataSource = dataset1.Tables[0];


        }
    }
}
