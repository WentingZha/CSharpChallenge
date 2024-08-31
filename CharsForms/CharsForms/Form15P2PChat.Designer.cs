namespace CharsForms
{
    partial class Form15P2PChat
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
            rtbContent = new RichTextBox();
            rtbSend = new RichTextBox();
            label1 = new Label();
            hostTb = new TextBox();
            nameTb = new TextBox();
            label2 = new Label();
            clearBtn = new Button();
            sendBtn = new Button();
            closeBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(2, 3);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(529, 300);
            rtbContent.TabIndex = 0;
            rtbContent.Text = "";
            // 
            // rtbSend
            // 
            rtbSend.Location = new Point(2, 309);
            rtbSend.Name = "rtbSend";
            rtbSend.Size = new Size(529, 102);
            rtbSend.TabIndex = 1;
            rtbSend.Text = "12345";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 421);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Friend's Host";
            // 
            // hostTb
            // 
            hostTb.Location = new Point(92, 418);
            hostTb.Name = "hostTb";
            hostTb.Size = new Size(237, 23);
            hostTb.TabIndex = 3;
            hostTb.Text = " 192.168.1.171";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(124, 451);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(205, 23);
            nameTb.TabIndex = 4;
            nameTb.Text = "ZhaWenTing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 454);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Friend's nick name";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(361, 417);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.TextAlign = ContentAlignment.TopCenter;
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(361, 450);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(75, 23);
            sendBtn.TabIndex = 7;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(442, 450);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 8;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form15P2PChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 501);
            Controls.Add(closeBtn);
            Controls.Add(sendBtn);
            Controls.Add(clearBtn);
            Controls.Add(label2);
            Controls.Add(nameTb);
            Controls.Add(hostTb);
            Controls.Add(label1);
            Controls.Add(rtbSend);
            Controls.Add(rtbContent);
            Name = "Form15P2PChat";
            Text = "Form15P2PChat";
            FormClosed += Form15P2PChat_FormClosed;
            Load += Form15P2PChat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbContent;
        private RichTextBox rtbSend;
        private Label label1;
        private TextBox hostTb;
        private TextBox nameTb;
        private Label label2;
        private Button clearBtn;
        private Button sendBtn;
        private Button closeBtn;
        private System.Windows.Forms.Timer timer1;
    }
}