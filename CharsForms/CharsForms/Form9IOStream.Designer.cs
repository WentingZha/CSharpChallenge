namespace CharsForms
{
    partial class Form9IOStream
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
            label1 = new Label();
            createFileTB = new TextBox();
            createFileBt = new Button();
            createFolderBtn = new Button();
            createFolderTB = new TextBox();
            label2 = new Label();
            createFilePathNameBtn = new Button();
            createFilePathNameTb = new TextBox();
            label3 = new Label();
            button1 = new Button();
            openFileTb = new TextBox();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            browseFolderBtn = new Button();
            browseFolderTb = new TextBox();
            label5 = new Label();
            browserFolderListView = new ListView();
            fileName = new ColumnHeader();
            filePath = new ColumnHeader();
            fileSize = new ColumnHeader();
            createTime = new ColumnHeader();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label6 = new Label();
            fileWriterTb = new TextBox();
            readBtn = new Button();
            writeBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            binaryWriteBtn = new Button();
            binaryReadBtn = new Button();
            binaryIOTextBox = new TextBox();
            label7 = new Label();
            copyFilesBtn1 = new Button();
            copyFilesTB1 = new TextBox();
            copyFilesListBox = new ListBox();
            openFilesBtn2 = new Button();
            copyFilesTB2 = new TextBox();
            copyFilesBtn3 = new Button();
            extractFilesBtn1 = new Button();
            extractFilesTb = new TextBox();
            extractFilesBtn2 = new Button();
            extractFilesBtnOpen = new Button();
            extractFilesTb2 = new TextBox();
            writeToMemoryTb3 = new TextBox();
            label8 = new Label();
            writeToBinaryBtn = new Button();
            writeToMemoryTb2 = new TextBox();
            label9 = new Label();
            writeToMemoryTb1 = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "File Name";
            // 
            // createFileTB
            // 
            createFileTB.Location = new Point(17, 36);
            createFileTB.Name = "createFileTB";
            createFileTB.Size = new Size(161, 23);
            createFileTB.TabIndex = 1;
            createFileTB.Text = "1";
            // 
            // createFileBt
            // 
            createFileBt.Location = new Point(56, 65);
            createFileBt.Name = "createFileBt";
            createFileBt.Size = new Size(75, 23);
            createFileBt.TabIndex = 2;
            createFileBt.Text = "Create";
            createFileBt.UseVisualStyleBackColor = true;
            createFileBt.Click += createFileBt_Click;
            // 
            // createFolderBtn
            // 
            createFolderBtn.Location = new Point(56, 175);
            createFolderBtn.Name = "createFolderBtn";
            createFolderBtn.Size = new Size(75, 23);
            createFolderBtn.TabIndex = 5;
            createFolderBtn.Text = "Create";
            createFolderBtn.UseVisualStyleBackColor = true;
            createFolderBtn.Click += createFolderBtn_Click;
            // 
            // createFolderTB
            // 
            createFolderTB.Location = new Point(17, 146);
            createFolderTB.Name = "createFolderTB";
            createFolderTB.Size = new Size(161, 23);
            createFolderTB.TabIndex = 4;
            createFolderTB.Text = "1/1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 128);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "Folder Path and Name:";
            // 
            // createFilePathNameBtn
            // 
            createFilePathNameBtn.Location = new Point(56, 288);
            createFilePathNameBtn.Name = "createFilePathNameBtn";
            createFilePathNameBtn.Size = new Size(75, 23);
            createFilePathNameBtn.TabIndex = 8;
            createFilePathNameBtn.Text = "Create";
            createFilePathNameBtn.UseVisualStyleBackColor = true;
            createFilePathNameBtn.Click += createFilePathNameBtn_Click;
            // 
            // createFilePathNameTb
            // 
            createFilePathNameTb.Location = new Point(17, 259);
            createFilePathNameTb.Name = "createFilePathNameTb";
            createFilePathNameTb.Size = new Size(161, 23);
            createFilePathNameTb.TabIndex = 7;
            createFilePathNameTb.Text = "Z:\\1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 241);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 6;
            label3.Text = "File Path and Name:";
            // 
            // button1
            // 
            button1.Location = new Point(57, 400);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileTb
            // 
            openFileTb.Location = new Point(18, 371);
            openFileTb.Name = "openFileTb";
            openFileTb.Size = new Size(161, 23);
            openFileTb.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 353);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "Choose file";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseFolderBtn
            // 
            browseFolderBtn.Location = new Point(572, 16);
            browseFolderBtn.Name = "browseFolderBtn";
            browseFolderBtn.Size = new Size(75, 23);
            browseFolderBtn.TabIndex = 14;
            browseFolderBtn.Text = "Browse";
            browseFolderBtn.UseVisualStyleBackColor = true;
            browseFolderBtn.Click += browseFolderBtn_Click;
            // 
            // browseFolderTb
            // 
            browseFolderTb.Location = new Point(332, 16);
            browseFolderTb.Name = "browseFolderTb";
            browseFolderTb.Size = new Size(219, 23);
            browseFolderTb.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 19);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 12;
            label5.Text = "Choose folder";
            // 
            // browserFolderListView
            // 
            browserFolderListView.Columns.AddRange(new ColumnHeader[] { fileName, filePath, fileSize, createTime });
            browserFolderListView.Location = new Point(245, 45);
            browserFolderListView.Name = "browserFolderListView";
            browserFolderListView.Size = new Size(412, 124);
            browserFolderListView.TabIndex = 15;
            browserFolderListView.UseCompatibleStateImageBehavior = false;
            browserFolderListView.View = View.Details;
            // 
            // fileName
            // 
            fileName.Text = "File Name";
            fileName.Width = 100;
            // 
            // filePath
            // 
            filePath.Text = "File Path";
            filePath.Width = 100;
            // 
            // fileSize
            // 
            fileSize.Text = "File Size";
            fileSize.Width = 100;
            // 
            // createTime
            // 
            createTime.Text = "Create Time";
            createTime.Width = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 210);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 16;
            label6.Text = "Text";
            // 
            // fileWriterTb
            // 
            fileWriterTb.Location = new Point(245, 228);
            fileWriterTb.Multiline = true;
            fileWriterTb.Name = "fileWriterTb";
            fileWriterTb.Size = new Size(180, 112);
            fileWriterTb.TabIndex = 17;
            // 
            // readBtn
            // 
            readBtn.Location = new Point(242, 353);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(75, 23);
            readBtn.TabIndex = 18;
            readBtn.Text = "Read";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // writeBtn
            // 
            writeBtn.Location = new Point(350, 353);
            writeBtn.Name = "writeBtn";
            writeBtn.Size = new Size(75, 23);
            writeBtn.TabIndex = 19;
            writeBtn.Text = "Write";
            writeBtn.UseVisualStyleBackColor = true;
            writeBtn.Click += writeBtn_Click;
            // 
            // binaryWriteBtn
            // 
            binaryWriteBtn.Location = new Point(584, 353);
            binaryWriteBtn.Name = "binaryWriteBtn";
            binaryWriteBtn.Size = new Size(75, 23);
            binaryWriteBtn.TabIndex = 23;
            binaryWriteBtn.Text = "Write";
            binaryWriteBtn.UseVisualStyleBackColor = true;
            binaryWriteBtn.Click += binaryWriteBtn_Click;
            // 
            // binaryReadBtn
            // 
            binaryReadBtn.Location = new Point(476, 353);
            binaryReadBtn.Name = "binaryReadBtn";
            binaryReadBtn.Size = new Size(75, 23);
            binaryReadBtn.TabIndex = 22;
            binaryReadBtn.Text = "Read";
            binaryReadBtn.UseVisualStyleBackColor = true;
            binaryReadBtn.Click += binaryReadBtn_Click;
            // 
            // binaryIOTextBox
            // 
            binaryIOTextBox.Location = new Point(479, 228);
            binaryIOTextBox.Multiline = true;
            binaryIOTextBox.Name = "binaryIOTextBox";
            binaryIOTextBox.Size = new Size(180, 112);
            binaryIOTextBox.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 210);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 20;
            label7.Text = "Binary";
            // 
            // copyFilesBtn1
            // 
            copyFilesBtn1.Location = new Point(728, 14);
            copyFilesBtn1.Name = "copyFilesBtn1";
            copyFilesBtn1.Size = new Size(105, 23);
            copyFilesBtn1.TabIndex = 24;
            copyFilesBtn1.Text = "Open Folder";
            copyFilesBtn1.UseVisualStyleBackColor = true;
            copyFilesBtn1.Click += copyFilesBtn1_Click;
            // 
            // copyFilesTB1
            // 
            copyFilesTB1.Location = new Point(727, 45);
            copyFilesTB1.Name = "copyFilesTB1";
            copyFilesTB1.Size = new Size(262, 23);
            copyFilesTB1.TabIndex = 25;
            // 
            // copyFilesListBox
            // 
            copyFilesListBox.FormattingEnabled = true;
            copyFilesListBox.ItemHeight = 15;
            copyFilesListBox.Location = new Point(728, 84);
            copyFilesListBox.Name = "copyFilesListBox";
            copyFilesListBox.SelectionMode = SelectionMode.MultiExtended;
            copyFilesListBox.Size = new Size(262, 124);
            copyFilesListBox.TabIndex = 26;
            // 
            // openFilesBtn2
            // 
            openFilesBtn2.Location = new Point(727, 228);
            openFilesBtn2.Name = "openFilesBtn2";
            openFilesBtn2.Size = new Size(75, 23);
            openFilesBtn2.TabIndex = 27;
            openFilesBtn2.Text = "Target";
            openFilesBtn2.UseVisualStyleBackColor = true;
            openFilesBtn2.Click += openFilesBtn2_Click;
            // 
            // copyFilesTB2
            // 
            copyFilesTB2.Location = new Point(808, 228);
            copyFilesTB2.Name = "copyFilesTB2";
            copyFilesTB2.Size = new Size(182, 23);
            copyFilesTB2.TabIndex = 28;
            // 
            // copyFilesBtn3
            // 
            copyFilesBtn3.Location = new Point(914, 259);
            copyFilesBtn3.Name = "copyFilesBtn3";
            copyFilesBtn3.Size = new Size(75, 23);
            copyFilesBtn3.TabIndex = 29;
            copyFilesBtn3.Text = "Copy";
            copyFilesBtn3.UseVisualStyleBackColor = true;
            copyFilesBtn3.Click += copyFilesBtn3_Click;
            // 
            // extractFilesBtn1
            // 
            extractFilesBtn1.Location = new Point(246, 584);
            extractFilesBtn1.Name = "extractFilesBtn1";
            extractFilesBtn1.Size = new Size(146, 23);
            extractFilesBtn1.TabIndex = 32;
            extractFilesBtn1.Text = "Extract Files";
            extractFilesBtn1.UseVisualStyleBackColor = true;
            extractFilesBtn1.Click += extractFilesBtn1_Click;
            // 
            // extractFilesTb
            // 
            extractFilesTb.Location = new Point(350, 425);
            extractFilesTb.Name = "extractFilesTb";
            extractFilesTb.Size = new Size(300, 23);
            extractFilesTb.TabIndex = 31;
            // 
            // extractFilesBtn2
            // 
            extractFilesBtn2.Location = new Point(572, 584);
            extractFilesBtn2.Name = "extractFilesBtn2";
            extractFilesBtn2.Size = new Size(75, 23);
            extractFilesBtn2.TabIndex = 34;
            extractFilesBtn2.Text = "Close";
            extractFilesBtn2.UseVisualStyleBackColor = true;
            extractFilesBtn2.Click += extractFilesBtn2_Click;
            // 
            // extractFilesBtnOpen
            // 
            extractFilesBtnOpen.Location = new Point(242, 425);
            extractFilesBtnOpen.Name = "extractFilesBtnOpen";
            extractFilesBtnOpen.Size = new Size(84, 23);
            extractFilesBtnOpen.TabIndex = 35;
            extractFilesBtnOpen.Text = "Open";
            extractFilesBtnOpen.UseVisualStyleBackColor = true;
            extractFilesBtnOpen.Click += extractFilesBtnOpen_Click;
            // 
            // extractFilesTb2
            // 
            extractFilesTb2.Location = new Point(246, 454);
            extractFilesTb2.Multiline = true;
            extractFilesTb2.Name = "extractFilesTb2";
            extractFilesTb2.Size = new Size(405, 112);
            extractFilesTb2.TabIndex = 36;
            // 
            // writeToMemoryTb3
            // 
            writeToMemoryTb3.Location = new Point(902, 417);
            writeToMemoryTb3.Multiline = true;
            writeToMemoryTb3.Name = "writeToMemoryTb3";
            writeToMemoryTb3.Size = new Size(131, 137);
            writeToMemoryTb3.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(902, 396);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 37;
            label8.Text = "Binary";
            // 
            // writeToBinaryBtn
            // 
            writeToBinaryBtn.Location = new Point(791, 578);
            writeToBinaryBtn.Name = "writeToBinaryBtn";
            writeToBinaryBtn.Size = new Size(151, 27);
            writeToBinaryBtn.TabIndex = 42;
            writeToBinaryBtn.Text = "Write and Read";
            writeToBinaryBtn.UseVisualStyleBackColor = true;
            writeToBinaryBtn.Click += writeToBinaryBtn_Click;
            // 
            // writeToMemoryTb2
            // 
            writeToMemoryTb2.Location = new Point(728, 417);
            writeToMemoryTb2.Multiline = true;
            writeToMemoryTb2.Name = "writeToMemoryTb2";
            writeToMemoryTb2.Size = new Size(140, 137);
            writeToMemoryTb2.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(728, 391);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 40;
            label9.Text = "Attribute";
            // 
            // writeToMemoryTb1
            // 
            writeToMemoryTb1.Location = new Point(727, 347);
            writeToMemoryTb1.Multiline = true;
            writeToMemoryTb1.Name = "writeToMemoryTb1";
            writeToMemoryTb1.Size = new Size(285, 29);
            writeToMemoryTb1.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(728, 329);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 43;
            label10.Text = "Write to memory";
            // 
            // Form9IOStream
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 646);
            Controls.Add(writeToMemoryTb1);
            Controls.Add(label10);
            Controls.Add(writeToBinaryBtn);
            Controls.Add(writeToMemoryTb2);
            Controls.Add(label9);
            Controls.Add(writeToMemoryTb3);
            Controls.Add(label8);
            Controls.Add(extractFilesTb2);
            Controls.Add(extractFilesBtnOpen);
            Controls.Add(extractFilesBtn2);
            Controls.Add(extractFilesBtn1);
            Controls.Add(extractFilesTb);
            Controls.Add(copyFilesBtn3);
            Controls.Add(copyFilesTB2);
            Controls.Add(openFilesBtn2);
            Controls.Add(copyFilesListBox);
            Controls.Add(copyFilesTB1);
            Controls.Add(copyFilesBtn1);
            Controls.Add(binaryWriteBtn);
            Controls.Add(binaryReadBtn);
            Controls.Add(binaryIOTextBox);
            Controls.Add(label7);
            Controls.Add(writeBtn);
            Controls.Add(readBtn);
            Controls.Add(fileWriterTb);
            Controls.Add(label6);
            Controls.Add(browserFolderListView);
            Controls.Add(browseFolderBtn);
            Controls.Add(browseFolderTb);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(openFileTb);
            Controls.Add(label4);
            Controls.Add(createFilePathNameBtn);
            Controls.Add(createFilePathNameTb);
            Controls.Add(label3);
            Controls.Add(createFolderBtn);
            Controls.Add(createFolderTB);
            Controls.Add(label2);
            Controls.Add(createFileBt);
            Controls.Add(createFileTB);
            Controls.Add(label1);
            Name = "Form9IOStream";
            Text = "Form9IO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox createFileTB;
        private Button createFileBt;
        private Button createFolderBtn;
        private TextBox createFolderTB;
        private Label label2;
        private Button createFilePathNameBtn;
        private TextBox createFilePathNameTb;
        private Label label3;
        private Button button1;
        private TextBox openFileTb;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Button browseFolderBtn;
        private TextBox browseFolderTb;
        private Label label5;
        private ListView browserFolderListView;
        private ColumnHeader fileName;
        private ColumnHeader filePath;
        private ColumnHeader fileSize;
        private ColumnHeader createTime;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label6;
        private TextBox fileWriterTb;
        private Button readBtn;
        private Button writeBtn;
        private SaveFileDialog saveFileDialog1;
        private Button binaryWriteBtn;
        private Button binaryReadBtn;
        private TextBox binaryIOTextBox;
        private Label label7;
        private Button copyFilesBtn1;
        private TextBox copyFilesTB1;
        private ListBox copyFilesListBox;
        private Button openFilesBtn2;
        private TextBox copyFilesTB2;
        private Button copyFilesBtn3;
        private Button extractFilesBtn1;
        private TextBox extractFilesTb;
        private Button extractFilesBtn2;
        private Button extractFilesBtnOpen;
        private TextBox extractFilesTb2;
        private TextBox writeToMemoryTb3;
        private Label label8;
        private Button writeToBinaryBtn;
        private TextBox writeToMemoryTb2;
        private Label label9;
        private TextBox writeToMemoryTb1;
        private Label label10;
    }
}