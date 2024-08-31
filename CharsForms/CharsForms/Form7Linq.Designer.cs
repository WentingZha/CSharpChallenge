namespace CharsForms
{
    partial class Form7Linq
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
            groupBox1 = new GroupBox();
            fileSelectBtn = new Button();
            folderPathTb = new TextBox();
            label1 = new Label();
            fileListView = new ListView();
            columnHeader1 = new ColumnHeader();
            groupBox2 = new GroupBox();
            label8 = new Label();
            fileLastEditTb = new TextBox();
            fileReadOnlyTb = new TextBox();
            fileCreateTimeTn = new TextBox();
            fileSizeTb = new TextBox();
            fileExtensionTb = new TextBox();
            fileNameTb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            linqSortGridView = new DataGridView();
            ascSortBtn = new Button();
            desSortBtn = new Button();
            top5Btn = new Button();
            refreshBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)linqSortGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fileSelectBtn);
            groupBox1.Controls.Add(folderPathTb);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 56);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setting";
            // 
            // fileSelectBtn
            // 
            fileSelectBtn.Location = new Point(304, 24);
            fileSelectBtn.Name = "fileSelectBtn";
            fileSelectBtn.Size = new Size(40, 23);
            fileSelectBtn.TabIndex = 2;
            fileSelectBtn.Text = "...";
            fileSelectBtn.UseVisualStyleBackColor = true;
            fileSelectBtn.Click += fileSelectBtn_Click;
            // 
            // folderPathTb
            // 
            folderPathTb.Location = new Point(90, 25);
            folderPathTb.Name = "folderPathTb";
            folderPathTb.Size = new Size(208, 23);
            folderPathTb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Select folder";
            // 
            // fileListView
            // 
            fileListView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            fileListView.GridLines = true;
            fileListView.Location = new Point(19, 98);
            fileListView.MultiSelect = false;
            fileListView.Name = "fileListView";
            fileListView.Size = new Size(362, 139);
            fileListView.TabIndex = 1;
            fileListView.UseCompatibleStateImageBehavior = false;
            fileListView.View = View.Details;
            fileListView.Click += fileListView_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File Name";
            columnHeader1.Width = 300;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(fileLastEditTb);
            groupBox2.Controls.Add(fileReadOnlyTb);
            groupBox2.Controls.Add(fileCreateTimeTn);
            groupBox2.Controls.Add(fileSizeTb);
            groupBox2.Controls.Add(fileExtensionTb);
            groupBox2.Controls.Add(fileNameTb);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(22, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 176);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(318, 58);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 12;
            label8.Text = "KB";
            // 
            // fileLastEditTb
            // 
            fileLastEditTb.Location = new Point(77, 112);
            fileLastEditTb.Name = "fileLastEditTb";
            fileLastEditTb.Size = new Size(263, 23);
            fileLastEditTb.TabIndex = 11;
            // 
            // fileReadOnlyTb
            // 
            fileReadOnlyTb.Location = new Point(77, 141);
            fileReadOnlyTb.Name = "fileReadOnlyTb";
            fileReadOnlyTb.Size = new Size(87, 23);
            fileReadOnlyTb.TabIndex = 10;
            // 
            // fileCreateTimeTn
            // 
            fileCreateTimeTn.Location = new Point(77, 83);
            fileCreateTimeTn.Name = "fileCreateTimeTn";
            fileCreateTimeTn.Size = new Size(263, 23);
            fileCreateTimeTn.TabIndex = 9;
            // 
            // fileSizeTb
            // 
            fileSizeTb.Location = new Point(223, 54);
            fileSizeTb.Name = "fileSizeTb";
            fileSizeTb.Size = new Size(87, 23);
            fileSizeTb.TabIndex = 8;
            // 
            // fileExtensionTb
            // 
            fileExtensionTb.Location = new Point(77, 54);
            fileExtensionTb.Name = "fileExtensionTb";
            fileExtensionTb.Size = new Size(87, 23);
            fileExtensionTb.TabIndex = 7;
            // 
            // fileNameTb
            // 
            fileNameTb.Location = new Point(77, 24);
            fileNameTb.Name = "fileNameTb";
            fileNameTb.Size = new Size(263, 23);
            fileNameTb.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 115);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 5;
            label7.Text = "Last edit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 144);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 4;
            label6.Text = "Read only";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 86);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 3;
            label5.Text = "Create time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 57);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 2;
            label4.Text = "File Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 1;
            label3.Text = "Extension";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "File Name";
            // 
            // linqSortGridView
            // 
            linqSortGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            linqSortGridView.Location = new Point(454, 35);
            linqSortGridView.Name = "linqSortGridView";
            linqSortGridView.Size = new Size(426, 203);
            linqSortGridView.TabIndex = 3;
            // 
            // ascSortBtn
            // 
            ascSortBtn.Location = new Point(454, 291);
            ascSortBtn.Name = "ascSortBtn";
            ascSortBtn.Size = new Size(166, 23);
            ascSortBtn.TabIndex = 4;
            ascSortBtn.Text = "Bonus Ascending";
            ascSortBtn.UseVisualStyleBackColor = true;
            ascSortBtn.Click += ascSortBtn_Click;
            // 
            // desSortBtn
            // 
            desSortBtn.Location = new Point(714, 286);
            desSortBtn.Name = "desSortBtn";
            desSortBtn.RightToLeft = RightToLeft.No;
            desSortBtn.Size = new Size(166, 23);
            desSortBtn.TabIndex = 5;
            desSortBtn.Text = "Bonus Descending";
            desSortBtn.UseVisualStyleBackColor = true;
            desSortBtn.Click += desSortBtn_Click;
            // 
            // top5Btn
            // 
            top5Btn.Location = new Point(714, 257);
            top5Btn.Name = "top5Btn";
            top5Btn.Size = new Size(166, 23);
            top5Btn.TabIndex = 6;
            top5Btn.Text = "Top 5 Salary";
            top5Btn.UseVisualStyleBackColor = true;
            top5Btn.Click += top5Btn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(454, 262);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(166, 23);
            refreshBtn.TabIndex = 7;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // Form7Linq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 492);
            Controls.Add(refreshBtn);
            Controls.Add(top5Btn);
            Controls.Add(desSortBtn);
            Controls.Add(ascSortBtn);
            Controls.Add(linqSortGridView);
            Controls.Add(groupBox2);
            Controls.Add(fileListView);
            Controls.Add(groupBox1);
            Name = "Form7Linq";
            Text = "Form7Linq";
            Load += Form7Linq_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)linqSortGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button fileSelectBtn;
        private TextBox folderPathTb;
        private Label label1;
        private ListView fileListView;
        private GroupBox groupBox2;
        private TextBox fileLastEditTb;
        private TextBox fileReadOnlyTb;
        private TextBox fileCreateTimeTn;
        private TextBox fileSizeTb;
        private TextBox fileExtensionTb;
        private TextBox fileNameTb;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private ColumnHeader columnHeader1;
        private Label label8;
        private DataGridView linqSortGridView;
        private Button ascSortBtn;
        private Button desSortBtn;
        private Button top5Btn;
        private Button refreshBtn;
    }
}