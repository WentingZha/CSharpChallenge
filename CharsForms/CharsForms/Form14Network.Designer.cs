namespace CharsForms
{
    partial class Form14Network
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
            label3 = new Label();
            label4 = new Label();
            hostAddrTb = new TextBox();
            ipAddrTb = new TextBox();
            localNameTb = new TextBox();
            dnsNameTb = new TextBox();
            checkBtn = new Button();
            ipAddrInfoLabel = new Label();
            ipEndPointLabel = new Label();
            label5 = new Label();
            downloadTb = new TextBox();
            downloadBtn = new Button();
            downloadRichTextBox = new RichTextBox();
            requestRichTb = new RichTextBox();
            sendRequstBtn = new Button();
            requestTb = new TextBox();
            label6 = new Label();
            tcpPortTb = new TextBox();
            tcpIPTb = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tcpBtn = new Button();
            tcpRichTb = new RichTextBox();
            label9 = new Label();
            udpTb = new TextBox();
            udpBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Host Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "IP Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 101);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Local Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 138);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "DNS Name";
            // 
            // hostAddrTb
            // 
            hostAddrTb.Location = new Point(118, 27);
            hostAddrTb.Name = "hostAddrTb";
            hostAddrTb.Size = new Size(175, 23);
            hostAddrTb.TabIndex = 4;
            hostAddrTb.Text = "127.0.0.1";
            // 
            // ipAddrTb
            // 
            ipAddrTb.Location = new Point(118, 61);
            ipAddrTb.Name = "ipAddrTb";
            ipAddrTb.ReadOnly = true;
            ipAddrTb.Size = new Size(175, 23);
            ipAddrTb.TabIndex = 5;
            // 
            // localNameTb
            // 
            localNameTb.Location = new Point(118, 98);
            localNameTb.Name = "localNameTb";
            localNameTb.ReadOnly = true;
            localNameTb.Size = new Size(175, 23);
            localNameTb.TabIndex = 6;
            // 
            // dnsNameTb
            // 
            dnsNameTb.Location = new Point(118, 135);
            dnsNameTb.Name = "dnsNameTb";
            dnsNameTb.ReadOnly = true;
            dnsNameTb.Size = new Size(175, 23);
            dnsNameTb.TabIndex = 7;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(299, 27);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(75, 23);
            checkBtn.TabIndex = 8;
            checkBtn.Text = "Check";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // ipAddrInfoLabel
            // 
            ipAddrInfoLabel.AutoSize = true;
            ipAddrInfoLabel.Location = new Point(28, 179);
            ipAddrInfoLabel.Name = "ipAddrInfoLabel";
            ipAddrInfoLabel.Size = new Size(124, 15);
            ipAddrInfoLabel.TabIndex = 9;
            ipAddrInfoLabel.Text = "IP Address infomation";
            // 
            // ipEndPointLabel
            // 
            ipEndPointLabel.AutoSize = true;
            ipEndPointLabel.Location = new Point(30, 247);
            ipEndPointLabel.Name = "ipEndPointLabel";
            ipEndPointLabel.Size = new Size(71, 15);
            ipEndPointLabel.TabIndex = 10;
            ipEndPointLabel.Text = "IP End Point";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 321);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 11;
            label5.Text = "Network Address";
            // 
            // downloadTb
            // 
            downloadTb.Location = new Point(30, 339);
            downloadTb.Name = "downloadTb";
            downloadTb.Size = new Size(238, 23);
            downloadTb.TabIndex = 12;
            // 
            // downloadBtn
            // 
            downloadBtn.Location = new Point(274, 339);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(100, 23);
            downloadBtn.TabIndex = 13;
            downloadBtn.Text = "Download";
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // downloadRichTextBox
            // 
            downloadRichTextBox.Location = new Point(31, 368);
            downloadRichTextBox.Name = "downloadRichTextBox";
            downloadRichTextBox.Size = new Size(343, 125);
            downloadRichTextBox.TabIndex = 14;
            downloadRichTextBox.Text = "";
            // 
            // requestRichTb
            // 
            requestRichTb.Location = new Point(7, 67);
            requestRichTb.Name = "requestRichTb";
            requestRichTb.Size = new Size(343, 172);
            requestRichTb.TabIndex = 15;
            requestRichTb.Text = "";
            // 
            // sendRequstBtn
            // 
            sendRequstBtn.Location = new Point(250, 38);
            sendRequstBtn.Name = "sendRequstBtn";
            sendRequstBtn.Size = new Size(100, 23);
            sendRequstBtn.TabIndex = 18;
            sendRequstBtn.Text = "Send Request";
            sendRequstBtn.UseVisualStyleBackColor = true;
            sendRequstBtn.Click += sendRequstBtn_Click;
            // 
            // requestTb
            // 
            requestTb.Location = new Point(6, 38);
            requestTb.Name = "requestTb";
            requestTb.Size = new Size(238, 23);
            requestTb.TabIndex = 17;
            requestTb.Text = "http://www.google.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 16;
            // 
            // tcpPortTb
            // 
            tcpPortTb.Location = new Point(87, 55);
            tcpPortTb.Name = "tcpPortTb";
            tcpPortTb.Size = new Size(172, 23);
            tcpPortTb.TabIndex = 22;
            tcpPortTb.Text = "100";
            // 
            // tcpIPTb
            // 
            tcpIPTb.Location = new Point(84, 28);
            tcpIPTb.Name = "tcpIPTb";
            tcpIPTb.Size = new Size(175, 23);
            tcpIPTb.TabIndex = 21;
            tcpIPTb.Text = "127.0.0.1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 61);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 20;
            label7.Text = "Port";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 31);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 19;
            label8.Text = "IP Address";
            // 
            // tcpBtn
            // 
            tcpBtn.Location = new Point(278, 27);
            tcpBtn.Name = "tcpBtn";
            tcpBtn.Size = new Size(75, 23);
            tcpBtn.TabIndex = 23;
            tcpBtn.Text = "TCP";
            tcpBtn.UseVisualStyleBackColor = true;
            tcpBtn.Click += tcpBtn_Click;
            // 
            // tcpRichTb
            // 
            tcpRichTb.Location = new Point(10, 121);
            tcpRichTb.Name = "tcpRichTb";
            tcpRichTb.Size = new Size(343, 133);
            tcpRichTb.TabIndex = 24;
            tcpRichTb.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 91);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 25;
            label9.Text = "Send message";
            // 
            // udpTb
            // 
            udpTb.Location = new Point(104, 88);
            udpTb.Name = "udpTb";
            udpTb.Size = new Size(249, 23);
            udpTb.TabIndex = 26;
            udpTb.Text = "This is Zha Wen Ting";
            // 
            // udpBtn
            // 
            udpBtn.Location = new Point(278, 56);
            udpBtn.Name = "udpBtn";
            udpBtn.Size = new Size(75, 23);
            udpBtn.TabIndex = 27;
            udpBtn.Text = "UDP";
            udpBtn.UseVisualStyleBackColor = true;
            udpBtn.Click += udpBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(requestRichTb);
            groupBox1.Controls.Add(sendRequstBtn);
            groupBox1.Controls.Add(requestTb);
            groupBox1.Location = new Point(396, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 254);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Network Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(udpBtn);
            groupBox2.Controls.Add(tcpIPTb);
            groupBox2.Controls.Add(udpTb);
            groupBox2.Controls.Add(tcpPortTb);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(tcpBtn);
            groupBox2.Controls.Add(tcpRichTb);
            groupBox2.Location = new Point(396, 296);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 271);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "TCP and UDP";
            // 
            // Form14Network
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 657);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(downloadRichTextBox);
            Controls.Add(downloadBtn);
            Controls.Add(downloadTb);
            Controls.Add(label5);
            Controls.Add(ipEndPointLabel);
            Controls.Add(ipAddrInfoLabel);
            Controls.Add(checkBtn);
            Controls.Add(dnsNameTb);
            Controls.Add(localNameTb);
            Controls.Add(ipAddrTb);
            Controls.Add(hostAddrTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form14Network";
            Text = "Form14Network";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox hostAddrTb;
        private TextBox ipAddrTb;
        private TextBox localNameTb;
        private TextBox dnsNameTb;
        private Button checkBtn;
        private Label ipAddrInfoLabel;
        private Label ipEndPointLabel;
        private Label label5;
        private TextBox downloadTb;
        private Button downloadBtn;
        private RichTextBox downloadRichTextBox;
        private RichTextBox requestRichTb;
        private Button sendRequstBtn;
        private TextBox requestTb;
        private Label label6;
        private TextBox tcpPortTb;
        private TextBox tcpIPTb;
        private Label label7;
        private Label label8;
        private Button tcpBtn;
        private RichTextBox tcpRichTb;
        private Label label9;
        private TextBox udpTb;
        private Button udpBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}