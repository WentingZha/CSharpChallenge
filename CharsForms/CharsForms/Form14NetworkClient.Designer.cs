namespace CharsForms
{
    partial class Form14NetworkClient
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
            label2 = new Label();
            serverTB = new TextBox();
            messageTB = new TextBox();
            sendBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Chat Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // serverTB
            // 
            serverTB.Location = new Point(105, 22);
            serverTB.Name = "serverTB";
            serverTB.Size = new Size(245, 23);
            serverTB.TabIndex = 2;
            serverTB.Text = "127.0.0.1";
            serverTB.KeyPress += serverTB_KeyPress;
            // 
            // messageTB
            // 
            messageTB.Location = new Point(105, 67);
            messageTB.Multiline = true;
            messageTB.Name = "messageTB";
            messageTB.Size = new Size(326, 114);
            messageTB.TabIndex = 3;
            messageTB.Text = "1234";
            messageTB.KeyPress += messageTB_KeyPress;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(356, 23);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(75, 23);
            sendBtn.TabIndex = 4;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // Form14NetworkClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 266);
            Controls.Add(sendBtn);
            Controls.Add(messageTB);
            Controls.Add(serverTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form14NetworkClient";
            Text = "Form14NetworkClient";
            FormClosing += Form14NetworkClient_FormClosing;
            Load += Form14NetworkClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox serverTB;
        private TextBox messageTB;
        private Button sendBtn;
    }
}