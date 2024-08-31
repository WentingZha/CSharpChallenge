namespace CharsForms
{
    partial class Form4AdvancedTools
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
            components = new System.ComponentModel.Container();
            treeView1 = new TreeView();
            treeViewLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            treeViewRemove = new Button();
            dateTimePickerTextBox = new TextBox();
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            helpProvider1 = new HelpProvider();
            helpBtn = new Button();
            timerTextBox = new TextBox();
            label7 = new Label();
            timerButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            progressTextBox = new TextBox();
            progressBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(34, 40);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(154, 204);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // treeViewLabel
            // 
            treeViewLabel.AutoSize = true;
            treeViewLabel.Location = new Point(34, 270);
            treeViewLabel.Name = "treeViewLabel";
            treeViewLabel.Size = new Size(80, 15);
            treeViewLabel.TabIndex = 1;
            treeViewLabel.Text = "treeViewLabel";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(231, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // treeViewRemove
            // 
            treeViewRemove.Location = new Point(34, 306);
            treeViewRemove.Name = "treeViewRemove";
            treeViewRemove.Size = new Size(75, 23);
            treeViewRemove.TabIndex = 3;
            treeViewRemove.Text = "Remove";
            treeViewRemove.UseVisualStyleBackColor = true;
            treeViewRemove.Click += treeViewRemove_Click;
            // 
            // dateTimePickerTextBox
            // 
            dateTimePickerTextBox.Location = new Point(231, 40);
            dateTimePickerTextBox.Name = "dateTimePickerTextBox";
            dateTimePickerTextBox.Size = new Size(212, 23);
            dateTimePickerTextBox.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(656, 40);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(657, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 126);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 92);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Start Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Today is ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(231, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 226);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Information";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(122, 124);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 23);
            textBox6.TabIndex = 7;
            textBox6.Validating += textBox6_Validating;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(122, 89);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 6;
            textBox5.Validating += textBox5_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 5;
            textBox4.Validating += textBox4_Validating;
            // 
            // button2
            // 
            button2.Location = new Point(182, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(57, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 127);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 2;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 89);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 1;
            label5.Text = "Product Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 56);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 0;
            label4.Text = "Product name";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // helpBtn
            // 
            helpBtn.Location = new Point(39, 366);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(75, 23);
            helpBtn.TabIndex = 8;
            helpBtn.Text = "Help Doc";
            helpBtn.UseVisualStyleBackColor = true;
            helpBtn.Click += helpBtn_Click;
            // 
            // timerTextBox
            // 
            timerTextBox.Location = new Point(39, 457);
            timerTextBox.Name = "timerTextBox";
            timerTextBox.Size = new Size(154, 23);
            timerTextBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 439);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 10;
            label7.Text = "Timer";
            // 
            // timerButton
            // 
            timerButton.Location = new Point(41, 495);
            timerButton.Name = "timerButton";
            timerButton.Size = new Size(75, 23);
            timerButton.TabIndex = 11;
            timerButton.Text = "Start";
            timerButton.UseVisualStyleBackColor = true;
            timerButton.Click += timerButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(658, 417);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(225, 23);
            progressBar1.TabIndex = 12;
            // 
            // progressTextBox
            // 
            progressTextBox.Location = new Point(659, 443);
            progressTextBox.Name = "progressTextBox";
            progressTextBox.Size = new Size(224, 23);
            progressTextBox.TabIndex = 13;
            progressTextBox.Text = "Progress";
            // 
            // progressBtn
            // 
            progressBtn.Location = new Point(740, 495);
            progressBtn.Name = "progressBtn";
            progressBtn.Size = new Size(75, 23);
            progressBtn.TabIndex = 14;
            progressBtn.Text = "Start";
            progressBtn.UseVisualStyleBackColor = true;
            progressBtn.Click += progressBtn_Click;
            // 
            // Form4AdvancedTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 544);
            Controls.Add(progressBtn);
            Controls.Add(progressTextBox);
            Controls.Add(progressBar1);
            Controls.Add(timerButton);
            Controls.Add(label7);
            Controls.Add(timerTextBox);
            Controls.Add(helpBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePickerTextBox);
            Controls.Add(treeViewRemove);
            Controls.Add(dateTimePicker1);
            Controls.Add(treeViewLabel);
            Controls.Add(treeView1);
            Name = "Form4AdvancedTools";
            Text = "Form4";
            Load += Form4AdvancedTools_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label treeViewLabel;
        private DateTimePicker dateTimePicker1;
        private Button treeViewRemove;
        private TextBox dateTimePickerTextBox;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private HelpProvider helpProvider1;
        private Button helpBtn;
        private Label label7;
        private TextBox timerTextBox;
        private Button timerButton;
        private System.Windows.Forms.Timer timer1;
        private Button progressBtn;
        private TextBox progressTextBox;
        private ProgressBar progressBar1;
    }
}