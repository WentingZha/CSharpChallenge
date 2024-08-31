namespace CharsForms
{
    partial class Form6DBView
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
            tableCellGridView = new DataGridView();
            tableCellBtn = new Button();
            tableCellLbl = new Label();
            loadDataBtn = new Button();
            editDataBtn = new Button();
            testDataBtn = new Button();
            styledDataGridView = new DataGridView();
            linqDataGridView = new DataGridView();
            linqQueryBtn = new Button();
            groupBox1 = new GroupBox();
            deleteXmlBtn = new Button();
            editXmlBtn = new Button();
            insertXmlBtn = new Button();
            xmlLinqGridView = new DataGridView();
            linqXmlGenderComboBox1 = new ComboBox();
            linqXmlSalaryTextBox = new TextBox();
            linqXmlNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linqXmlCheckBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)tableCellGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)styledDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linqDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xmlLinqGridView).BeginInit();
            SuspendLayout();
            // 
            // tableCellGridView
            // 
            tableCellGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCellGridView.Location = new Point(22, 41);
            tableCellGridView.Name = "tableCellGridView";
            tableCellGridView.Size = new Size(375, 150);
            tableCellGridView.TabIndex = 0;
            tableCellGridView.CellClick += tableCellGridView_CellClick;
            // 
            // tableCellBtn
            // 
            tableCellBtn.Location = new Point(22, 241);
            tableCellBtn.Name = "tableCellBtn";
            tableCellBtn.Size = new Size(75, 23);
            tableCellBtn.TabIndex = 1;
            tableCellBtn.Text = "Table cell";
            tableCellBtn.UseVisualStyleBackColor = true;
            tableCellBtn.Click += tableCellBtn_Click;
            // 
            // tableCellLbl
            // 
            tableCellLbl.AutoSize = true;
            tableCellLbl.Location = new Point(118, 241);
            tableCellLbl.Name = "tableCellLbl";
            tableCellLbl.Size = new Size(72, 15);
            tableCellLbl.TabIndex = 2;
            tableCellLbl.Text = "Selected cell";
            // 
            // loadDataBtn
            // 
            loadDataBtn.Location = new Point(22, 209);
            loadDataBtn.Name = "loadDataBtn";
            loadDataBtn.Size = new Size(75, 23);
            loadDataBtn.TabIndex = 3;
            loadDataBtn.Text = "Load Data";
            loadDataBtn.UseVisualStyleBackColor = true;
            loadDataBtn.Click += loadDataBtn_Click;
            // 
            // editDataBtn
            // 
            editDataBtn.Location = new Point(118, 209);
            editDataBtn.Name = "editDataBtn";
            editDataBtn.Size = new Size(75, 23);
            editDataBtn.TabIndex = 4;
            editDataBtn.Text = "Edit Data";
            editDataBtn.UseVisualStyleBackColor = true;
            editDataBtn.Click += editDataBtn_Click;
            // 
            // testDataBtn
            // 
            testDataBtn.Location = new Point(22, 490);
            testDataBtn.Name = "testDataBtn";
            testDataBtn.Size = new Size(75, 23);
            testDataBtn.TabIndex = 5;
            testDataBtn.Text = "Test Data";
            testDataBtn.UseVisualStyleBackColor = true;
            testDataBtn.Click += testDataBtn_Click;
            // 
            // styledDataGridView
            // 
            styledDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            styledDataGridView.Location = new Point(22, 315);
            styledDataGridView.Name = "styledDataGridView";
            styledDataGridView.Size = new Size(375, 150);
            styledDataGridView.TabIndex = 6;
            // 
            // linqDataGridView
            // 
            linqDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            linqDataGridView.Location = new Point(489, 41);
            linqDataGridView.Name = "linqDataGridView";
            linqDataGridView.Size = new Size(375, 150);
            linqDataGridView.TabIndex = 7;
            // 
            // linqQueryBtn
            // 
            linqQueryBtn.Location = new Point(489, 209);
            linqQueryBtn.Name = "linqQueryBtn";
            linqQueryBtn.Size = new Size(75, 23);
            linqQueryBtn.TabIndex = 8;
            linqQueryBtn.Text = "Linq query";
            linqQueryBtn.UseVisualStyleBackColor = true;
            linqQueryBtn.Click += linqQueryBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linqXmlCheckBtn);
            groupBox1.Controls.Add(deleteXmlBtn);
            groupBox1.Controls.Add(editXmlBtn);
            groupBox1.Controls.Add(insertXmlBtn);
            groupBox1.Controls.Add(xmlLinqGridView);
            groupBox1.Controls.Add(linqXmlGenderComboBox1);
            groupBox1.Controls.Add(linqXmlSalaryTextBox);
            groupBox1.Controls.Add(linqXmlNameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(489, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 298);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Linq Xml";
            // 
            // deleteXmlBtn
            // 
            deleteXmlBtn.Location = new Point(383, 68);
            deleteXmlBtn.Name = "deleteXmlBtn";
            deleteXmlBtn.Size = new Size(75, 23);
            deleteXmlBtn.TabIndex = 9;
            deleteXmlBtn.Text = "Delete";
            deleteXmlBtn.UseVisualStyleBackColor = true;
            deleteXmlBtn.Click += delXmlBtn_Click;
            // 
            // editXmlBtn
            // 
            editXmlBtn.Location = new Point(288, 68);
            editXmlBtn.Name = "editXmlBtn";
            editXmlBtn.Size = new Size(75, 23);
            editXmlBtn.TabIndex = 8;
            editXmlBtn.Text = "Edit";
            editXmlBtn.UseVisualStyleBackColor = true;
            editXmlBtn.Click += editXmlBtn_Click;
            // 
            // insertXmlBtn
            // 
            insertXmlBtn.Location = new Point(196, 68);
            insertXmlBtn.Name = "insertXmlBtn";
            insertXmlBtn.Size = new Size(75, 23);
            insertXmlBtn.TabIndex = 7;
            insertXmlBtn.Text = "Insert";
            insertXmlBtn.UseVisualStyleBackColor = true;
            insertXmlBtn.Click += insertXmlBtn_Click;
            // 
            // xmlLinqGridView
            // 
            xmlLinqGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            xmlLinqGridView.Location = new Point(15, 107);
            xmlLinqGridView.Name = "xmlLinqGridView";
            xmlLinqGridView.Size = new Size(478, 174);
            xmlLinqGridView.TabIndex = 6;
            xmlLinqGridView.CellClick += xmlLinqGridView_CellClick;
            // 
            // linqXmlGenderComboBox1
            // 
            linqXmlGenderComboBox1.FormattingEnabled = true;
            linqXmlGenderComboBox1.Location = new Point(233, 29);
            linqXmlGenderComboBox1.Name = "linqXmlGenderComboBox1";
            linqXmlGenderComboBox1.Size = new Size(121, 23);
            linqXmlGenderComboBox1.TabIndex = 5;
            // 
            // linqXmlSalaryTextBox
            // 
            linqXmlSalaryTextBox.Location = new Point(54, 68);
            linqXmlSalaryTextBox.Name = "linqXmlSalaryTextBox";
            linqXmlSalaryTextBox.Size = new Size(100, 23);
            linqXmlSalaryTextBox.TabIndex = 4;
            // 
            // linqXmlNameTextBox
            // 
            linqXmlNameTextBox.Location = new Point(54, 28);
            linqXmlNameTextBox.Name = "linqXmlNameTextBox";
            linqXmlNameTextBox.Size = new Size(100, 23);
            linqXmlNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Salary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 29);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // linqXmlCheckBtn
            // 
            linqXmlCheckBtn.Location = new Point(383, 27);
            linqXmlCheckBtn.Name = "linqXmlCheckBtn";
            linqXmlCheckBtn.Size = new Size(110, 23);
            linqXmlCheckBtn.TabIndex = 10;
            linqXmlCheckBtn.Text = "Linq Xml check";
            linqXmlCheckBtn.UseVisualStyleBackColor = true;
            linqXmlCheckBtn.Click += linqXmlCheckBtn_Click;
            // 
            // Form6DBView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 580);
            Controls.Add(groupBox1);
            Controls.Add(linqQueryBtn);
            Controls.Add(linqDataGridView);
            Controls.Add(styledDataGridView);
            Controls.Add(testDataBtn);
            Controls.Add(editDataBtn);
            Controls.Add(loadDataBtn);
            Controls.Add(tableCellLbl);
            Controls.Add(tableCellBtn);
            Controls.Add(tableCellGridView);
            Name = "Form6DBView";
            Text = "Form6DBView";
            Load += Form6DBView_Load;
            ((System.ComponentModel.ISupportInitialize)tableCellGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)styledDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)linqDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)xmlLinqGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableCellGridView;
        private Button tableCellBtn;
        private Label tableCellLbl;
        private Button loadDataBtn;
        private Button editDataBtn;
        private Button testDataBtn;
        private DataGridView styledDataGridView;
        private DataGridView linqDataGridView;
        private Button linqQueryBtn;
        private GroupBox groupBox1;
        private Button deleteXmlBtn;
        private Button editXmlBtn;
        private Button insertXmlBtn;
        private DataGridView xmlLinqGridView;
        private ComboBox linqXmlGenderComboBox1;
        private TextBox linqXmlSalaryTextBox;
        private TextBox linqXmlNameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button linqXmlCheckBtn;
    }
}