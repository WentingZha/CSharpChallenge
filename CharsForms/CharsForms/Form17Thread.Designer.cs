namespace CharsForms
{
    partial class Form17Thread
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
            rtbThreadProperty = new RichTextBox();
            lblThreadStatus = new Label();
            animateBtn = new Button();
            createThreadBtn = new Button();
            openPictureBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            connThreadBtn = new Button();
            insertThreadBtn = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // rtbThreadProperty
            // 
            rtbThreadProperty.Location = new Point(12, 12);
            rtbThreadProperty.Name = "rtbThreadProperty";
            rtbThreadProperty.Size = new Size(220, 96);
            rtbThreadProperty.TabIndex = 0;
            rtbThreadProperty.Text = "";
            // 
            // lblThreadStatus
            // 
            lblThreadStatus.AutoSize = true;
            lblThreadStatus.Location = new Point(12, 124);
            lblThreadStatus.Name = "lblThreadStatus";
            lblThreadStatus.Size = new Size(78, 15);
            lblThreadStatus.TabIndex = 1;
            lblThreadStatus.Text = "Thread Status";
            // 
            // animateBtn
            // 
            animateBtn.Location = new Point(12, 246);
            animateBtn.Name = "animateBtn";
            animateBtn.Size = new Size(135, 23);
            animateBtn.TabIndex = 2;
            animateBtn.Text = "Animate";
            animateBtn.UseVisualStyleBackColor = true;
            animateBtn.Click += animateBtn_Click;
            // 
            // createThreadBtn
            // 
            createThreadBtn.Location = new Point(15, 142);
            createThreadBtn.Name = "createThreadBtn";
            createThreadBtn.Size = new Size(75, 23);
            createThreadBtn.TabIndex = 4;
            createThreadBtn.Text = "Create Thread";
            createThreadBtn.UseVisualStyleBackColor = true;
            createThreadBtn.Click += createThreadBtn_Click;
            // 
            // openPictureBtn
            // 
            openPictureBtn.Location = new Point(15, 203);
            openPictureBtn.Name = "openPictureBtn";
            openPictureBtn.Size = new Size(135, 23);
            openPictureBtn.TabIndex = 2;
            openPictureBtn.Text = "Open Picture";
            openPictureBtn.UseVisualStyleBackColor = true;
            openPictureBtn.Click += openPictureBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // connThreadBtn
            // 
            connThreadBtn.Location = new Point(363, 233);
            connThreadBtn.Name = "connThreadBtn";
            connThreadBtn.Size = new Size(220, 23);
            connThreadBtn.TabIndex = 5;
            connThreadBtn.Text = "Start DB Connection Thread";
            connThreadBtn.UseVisualStyleBackColor = true;
            connThreadBtn.Click += connThreadBtn_Click;
            // 
            // insertThreadBtn
            // 
            insertThreadBtn.Location = new Point(363, 279);
            insertThreadBtn.Name = "insertThreadBtn";
            insertThreadBtn.Size = new Size(220, 23);
            insertThreadBtn.TabIndex = 6;
            insertThreadBtn.Text = "Start Insert Thread";
            insertThreadBtn.UseVisualStyleBackColor = true;
            insertThreadBtn.Click += insertThreadBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(296, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(328, 187);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // Form17Thread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 314);
            Controls.Add(richTextBox1);
            Controls.Add(insertThreadBtn);
            Controls.Add(connThreadBtn);
            Controls.Add(createThreadBtn);
            Controls.Add(openPictureBtn);
            Controls.Add(animateBtn);
            Controls.Add(lblThreadStatus);
            Controls.Add(rtbThreadProperty);
            Name = "Form17Thread";
            Text = "Form17Thread";
            Load += Form17Thread_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbThreadProperty;
        private Label lblThreadStatus;
        private Button animateBtn;
        private Button createThreadBtn;
        private Button openPictureBtn;
        private OpenFileDialog openFileDialog1;
        private Button connThreadBtn;
        private Button insertThreadBtn;
        private RichTextBox richTextBox1;
    }
}