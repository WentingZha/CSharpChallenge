namespace CharsForms
{
    partial class Form13Printer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13Printer));
            pageSetupBtn = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialogBtn = new Button();
            printDialog1 = new PrintDialog();
            browseTextBtn = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewControl1 = new PrintPreviewControl();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            groupBox1 = new GroupBox();
            printBtn = new Button();
            printPositionTb = new TextBox();
            printDeptTb = new TextBox();
            printNameTb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            printDocument3 = new System.Drawing.Printing.PrintDocument();
            printDialog2 = new PrintDialog();
            printPreviewDialog2 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pageSetupBtn
            // 
            pageSetupBtn.Location = new Point(46, 39);
            pageSetupBtn.Name = "pageSetupBtn";
            pageSetupBtn.Size = new Size(114, 23);
            pageSetupBtn.TabIndex = 0;
            pageSetupBtn.Text = "Set the page";
            pageSetupBtn.UseVisualStyleBackColor = true;
            pageSetupBtn.Click += pageSetupBtn_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialogBtn
            // 
            printDialogBtn.Location = new Point(46, 94);
            printDialogBtn.Name = "printDialogBtn";
            printDialogBtn.Size = new Size(114, 23);
            printDialogBtn.TabIndex = 1;
            printDialogBtn.Text = "Print Dialog";
            printDialogBtn.UseVisualStyleBackColor = true;
            printDialogBtn.Click += printDialogBtn_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // browseTextBtn
            // 
            browseTextBtn.Location = new Point(46, 148);
            browseTextBtn.Name = "browseTextBtn";
            browseTextBtn.Size = new Size(114, 23);
            browseTextBtn.TabIndex = 2;
            browseTextBtn.Text = "Browse the text";
            browseTextBtn.UseVisualStyleBackColor = true;
            browseTextBtn.Click += browseTextBtn_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Location = new Point(202, 39);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(521, 435);
            printPreviewControl1.TabIndex = 3;
            // 
            // printDocument2
            // 
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(printBtn);
            groupBox1.Controls.Add(printPositionTb);
            groupBox1.Controls.Add(printDeptTb);
            groupBox1.Controls.Add(printNameTb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(786, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 184);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Print";
            // 
            // printBtn
            // 
            printBtn.Location = new Point(113, 145);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(75, 23);
            printBtn.TabIndex = 6;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // printPositionTb
            // 
            printPositionTb.Location = new Point(83, 98);
            printPositionTb.Name = "printPositionTb";
            printPositionTb.Size = new Size(184, 23);
            printPositionTb.TabIndex = 5;
            // 
            // printDeptTb
            // 
            printDeptTb.Location = new Point(83, 63);
            printDeptTb.Name = "printDeptTb";
            printDeptTb.Size = new Size(184, 23);
            printDeptTb.TabIndex = 4;
            // 
            // printNameTb
            // 
            printNameTb.Location = new Point(83, 30);
            printNameTb.Name = "printNameTb";
            printNameTb.Size = new Size(184, 23);
            printNameTb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 98);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Dept";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // printDocument3
            // 
            printDocument3.PrintPage += printDocument3_PrintPage;
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog2.ClientSize = new Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            // 
            // Form13Printer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 524);
            Controls.Add(groupBox1);
            Controls.Add(printPreviewControl1);
            Controls.Add(browseTextBtn);
            Controls.Add(printDialogBtn);
            Controls.Add(pageSetupBtn);
            Name = "Form13Printer";
            Text = "Form13Printer";
            Load += Form13Printer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button pageSetupBtn;
        private PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button printDialogBtn;
        private PrintDialog printDialog1;
        private Button browseTextBtn;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintPreviewControl printPreviewControl1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private GroupBox groupBox1;
        private Button printBtn;
        private TextBox printPositionTb;
        private TextBox printDeptTb;
        private TextBox printNameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private PrintDialog printDialog2;
        private PrintPreviewDialog printPreviewDialog2;
    }
}