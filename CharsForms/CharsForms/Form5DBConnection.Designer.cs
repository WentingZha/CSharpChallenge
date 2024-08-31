namespace CharsForms
{
    partial class Form5DBConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dbConnBtn = new Button();
            label1 = new Label();
            dbConnTextBox = new TextBox();
            connBnt1 = new Button();
            connBtn2 = new Button();
            richTextBox1 = new RichTextBox();
            commandCheckTextBox = new TextBox();
            label2 = new Label();
            dbConnCheckBtn = new Button();
            commandCheckLabel = new Label();
            commandUpdateBtn = new Button();
            commandReaderBtn = new Button();
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            dataGridViewBtn = new Button();
            label3 = new Label();
            dataAdapterNameTextBox = new TextBox();
            label6 = new Label();
            dataAdapterBonusTextBox = new TextBox();
            button1 = new Button();
            label4 = new Label();
            dataAdapterIDTextBox = new TextBox();
            dataAdapterLevelTextBox = new TextBox();
            label5 = new Label();
            datasetDataView = new DataGridView();
            datasetBtn = new Button();
            copyGridView1 = new DataGridView();
            copyDataSetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datasetDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)copyGridView1).BeginInit();
            SuspendLayout();
            // 
            // dbConnBtn
            // 
            dbConnBtn.Location = new Point(204, 20);
            dbConnBtn.Name = "dbConnBtn";
            dbConnBtn.Size = new Size(75, 23);
            dbConnBtn.TabIndex = 0;
            dbConnBtn.Text = "Connect";
            dbConnBtn.UseVisualStyleBackColor = true;
            dbConnBtn.Click += dbConnBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "DB Name";
            // 
            // dbConnTextBox
            // 
            dbConnTextBox.Location = new Point(87, 20);
            dbConnTextBox.Name = "dbConnTextBox";
            dbConnTextBox.Size = new Size(100, 23);
            dbConnTextBox.TabIndex = 2;
            dbConnTextBox.Text = "zhadb";
            // 
            // connBnt1
            // 
            connBnt1.Location = new Point(25, 60);
            connBnt1.Name = "connBnt1";
            connBnt1.Size = new Size(254, 23);
            connBnt1.TabIndex = 3;
            connBnt1.Text = "CLose Connection and Open again";
            connBnt1.UseVisualStyleBackColor = true;
            connBnt1.Click += connBtn1_Click;
            // 
            // connBtn2
            // 
            connBtn2.Location = new Point(25, 89);
            connBtn2.Name = "connBtn2";
            connBtn2.Size = new Size(254, 23);
            connBtn2.TabIndex = 4;
            connBtn2.Text = "Dispose Connection and Open again";
            connBtn2.UseVisualStyleBackColor = true;
            connBtn2.Click += connBtn2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 118);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(252, 72);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // commandCheckTextBox
            // 
            commandCheckTextBox.Location = new Point(103, 282);
            commandCheckTextBox.Name = "commandCheckTextBox";
            commandCheckTextBox.Size = new Size(100, 23);
            commandCheckTextBox.TabIndex = 6;
            commandCheckTextBox.Text = "dbuser";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 285);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Table Name";
            // 
            // dbConnCheckBtn
            // 
            dbConnCheckBtn.Location = new Point(209, 282);
            dbConnCheckBtn.Name = "dbConnCheckBtn";
            dbConnCheckBtn.Size = new Size(75, 23);
            dbConnCheckBtn.TabIndex = 8;
            dbConnCheckBtn.Text = "Check";
            dbConnCheckBtn.UseVisualStyleBackColor = true;
            dbConnCheckBtn.Click += dbConnCheckBtn_Click;
            // 
            // commandCheckLabel
            // 
            commandCheckLabel.AutoSize = true;
            commandCheckLabel.Location = new Point(32, 348);
            commandCheckLabel.Name = "commandCheckLabel";
            commandCheckLabel.Size = new Size(65, 15);
            commandCheckLabel.TabIndex = 9;
            commandCheckLabel.Text = "Data count";
            // 
            // commandUpdateBtn
            // 
            commandUpdateBtn.Location = new Point(32, 311);
            commandUpdateBtn.Name = "commandUpdateBtn";
            commandUpdateBtn.Size = new Size(255, 23);
            commandUpdateBtn.TabIndex = 10;
            commandUpdateBtn.Text = "Bonus Day";
            commandUpdateBtn.UseVisualStyleBackColor = true;
            commandUpdateBtn.Click += commandUpdateBtn_Click;
            // 
            // commandReaderBtn
            // 
            commandReaderBtn.Location = new Point(28, 468);
            commandReaderBtn.Name = "commandReaderBtn";
            commandReaderBtn.Size = new Size(122, 23);
            commandReaderBtn.TabIndex = 11;
            commandReaderBtn.Text = "Display Name";
            commandReaderBtn.UseVisualStyleBackColor = true;
            commandReaderBtn.Click += commandReaderBtn_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 497);
            listView1.Name = "listView1";
            listView1.Size = new Size(255, 97);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(378, 150);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridViewBtn
            // 
            dataGridViewBtn.Location = new Point(343, 188);
            dataGridViewBtn.Name = "dataGridViewBtn";
            dataGridViewBtn.Size = new Size(169, 23);
            dataGridViewBtn.TabIndex = 14;
            dataGridViewBtn.Text = "Load DataGridView";
            dataGridViewBtn.UseVisualStyleBackColor = true;
            dataGridViewBtn.Click += dataGridViewBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 233);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 15;
            label3.Text = "Name";
            // 
            // dataAdapterNameTextBox
            // 
            dataAdapterNameTextBox.Location = new Point(620, 230);
            dataAdapterNameTextBox.Name = "dataAdapterNameTextBox";
            dataAdapterNameTextBox.Size = new Size(100, 23);
            dataAdapterNameTextBox.TabIndex = 16;
            dataAdapterNameTextBox.Text = "ZhaWenTing";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 268);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 21;
            label6.Text = "Bonus";
            // 
            // dataAdapterBonusTextBox
            // 
            dataAdapterBonusTextBox.Location = new Point(390, 265);
            dataAdapterBonusTextBox.Name = "dataAdapterBonusTextBox";
            dataAdapterBonusTextBox.Size = new Size(100, 23);
            dataAdapterBonusTextBox.TabIndex = 22;
            dataAdapterBonusTextBox.Text = "1000";
            // 
            // button1
            // 
            button1.Location = new Point(566, 188);
            button1.Name = "button1";
            button1.Size = new Size(155, 23);
            button1.TabIndex = 23;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += dataAdapterEditBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 233);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 24;
            label4.Text = "ID";
            // 
            // dataAdapterIDTextBox
            // 
            dataAdapterIDTextBox.Location = new Point(388, 230);
            dataAdapterIDTextBox.Name = "dataAdapterIDTextBox";
            dataAdapterIDTextBox.Size = new Size(100, 23);
            dataAdapterIDTextBox.TabIndex = 25;
            dataAdapterIDTextBox.Text = "1";
            // 
            // dataAdapterLevelTextBox
            // 
            dataAdapterLevelTextBox.Location = new Point(621, 268);
            dataAdapterLevelTextBox.Name = "dataAdapterLevelTextBox";
            dataAdapterLevelTextBox.Size = new Size(100, 23);
            dataAdapterLevelTextBox.TabIndex = 26;
            dataAdapterLevelTextBox.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 271);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 27;
            label5.Text = "Level";
            // 
            // datasetDataView
            // 
            datasetDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasetDataView.Location = new Point(343, 317);
            datasetDataView.Name = "datasetDataView";
            datasetDataView.Size = new Size(378, 264);
            datasetDataView.TabIndex = 28;
            // 
            // datasetBtn
            // 
            datasetBtn.Location = new Point(344, 587);
            datasetBtn.Name = "datasetBtn";
            datasetBtn.Size = new Size(362, 23);
            datasetBtn.TabIndex = 29;
            datasetBtn.Text = "Two Datasets";
            datasetBtn.UseVisualStyleBackColor = true;
            datasetBtn.Click += datasetBtn_Click;
            // 
            // copyGridView1
            // 
            copyGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            copyGridView1.Location = new Point(778, 20);
            copyGridView1.Name = "copyGridView1";
            copyGridView1.Size = new Size(378, 150);
            copyGridView1.TabIndex = 30;
            // 
            // copyDataSetBtn
            // 
            copyDataSetBtn.Location = new Point(778, 188);
            copyDataSetBtn.Name = "copyDataSetBtn";
            copyDataSetBtn.Size = new Size(378, 23);
            copyDataSetBtn.TabIndex = 31;
            copyDataSetBtn.Text = "Copy DataSet";
            copyDataSetBtn.UseVisualStyleBackColor = true;
            copyDataSetBtn.Click += copyDataSetBtn_Click;
            // 
            // Form5DBConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 639);
            Controls.Add(copyDataSetBtn);
            Controls.Add(copyGridView1);
            Controls.Add(datasetBtn);
            Controls.Add(datasetDataView);
            Controls.Add(label5);
            Controls.Add(dataAdapterLevelTextBox);
            Controls.Add(dataAdapterIDTextBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(dataAdapterBonusTextBox);
            Controls.Add(label6);
            Controls.Add(dataAdapterNameTextBox);
            Controls.Add(label3);
            Controls.Add(dataGridViewBtn);
            Controls.Add(dataGridView1);
            Controls.Add(listView1);
            Controls.Add(commandReaderBtn);
            Controls.Add(commandUpdateBtn);
            Controls.Add(commandCheckLabel);
            Controls.Add(dbConnCheckBtn);
            Controls.Add(label2);
            Controls.Add(commandCheckTextBox);
            Controls.Add(richTextBox1);
            Controls.Add(connBtn2);
            Controls.Add(connBnt1);
            Controls.Add(dbConnTextBox);
            Controls.Add(label1);
            Controls.Add(dbConnBtn);
            Name = "Form5DBConnection";
            Text = "Form5DBConnection";
            Load += Form5DBConnection_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datasetDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)copyGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dbConnBtn;
        private Label label1;
        private TextBox dbConnTextBox;
        private Button connBnt1;
        private Button connBtn2;
        private RichTextBox richTextBox1;
        private TextBox commandCheckTextBox;
        private Label label2;
        private Button dbConnCheckBtn;
        private Label commandCheckLabel;
        private Button commandUpdateBtn;
        private Button commandReaderBtn;
        private ListView listView1;
        private DataGridView dataGridView1;
        private Button dataGridViewBtn;
        private Label label3;
        private TextBox dataAdapterNameTextBox;
        private Label label6;
        private TextBox dataAdapterBonusTextBox;
        private Button button1;
        private Label label4;
        private TextBox dataAdapterIDTextBox;
        private TextBox dataAdapterLevelTextBox;
        private Label label5;
        private DataGridView datasetDataView;
        private Button datasetBtn;
        private DataGridView copyGridView1;
        private Button copyDataSetBtn;
    }
}