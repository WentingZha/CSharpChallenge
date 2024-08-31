namespace CharsForms
{
    partial class Form8SyntaxAdvanced
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
            enumeratorRichTB = new RichTextBox();
            groupBox2 = new GroupBox();
            partialClassTb3 = new TextBox();
            partialClassBtn = new Button();
            partialClassTb2 = new TextBox();
            partialClassCB = new ComboBox();
            partialClassTb1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(enumeratorRichTB);
            groupBox1.Location = new Point(33, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerator";
            // 
            // enumeratorRichTB
            // 
            enumeratorRichTB.Location = new Point(11, 28);
            enumeratorRichTB.Name = "enumeratorRichTB";
            enumeratorRichTB.Size = new Size(289, 96);
            enumeratorRichTB.TabIndex = 0;
            enumeratorRichTB.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(partialClassTb3);
            groupBox2.Controls.Add(partialClassBtn);
            groupBox2.Controls.Add(partialClassTb2);
            groupBox2.Controls.Add(partialClassCB);
            groupBox2.Controls.Add(partialClassTb1);
            groupBox2.Location = new Point(41, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Partial Class";
            // 
            // partialClassTb3
            // 
            partialClassTb3.Location = new Point(141, 70);
            partialClassTb3.Name = "partialClassTb3";
            partialClassTb3.Size = new Size(100, 23);
            partialClassTb3.TabIndex = 4;
            // 
            // partialClassBtn
            // 
            partialClassBtn.Location = new Point(60, 69);
            partialClassBtn.Name = "partialClassBtn";
            partialClassBtn.Size = new Size(75, 23);
            partialClassBtn.TabIndex = 3;
            partialClassBtn.Text = "=";
            partialClassBtn.UseVisualStyleBackColor = true;
            partialClassBtn.Click += partialClassBtn_Click;
            // 
            // partialClassTb2
            // 
            partialClassTb2.Location = new Point(173, 30);
            partialClassTb2.Name = "partialClassTb2";
            partialClassTb2.Size = new Size(79, 23);
            partialClassTb2.TabIndex = 2;
            // 
            // partialClassCB
            // 
            partialClassCB.FormattingEnabled = true;
            partialClassCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            partialClassCB.Location = new Point(106, 30);
            partialClassCB.Name = "partialClassCB";
            partialClassCB.Size = new Size(61, 23);
            partialClassCB.TabIndex = 1;
            // 
            // partialClassTb1
            // 
            partialClassTb1.Location = new Point(23, 30);
            partialClassTb1.Name = "partialClassTb1";
            partialClassTb1.Size = new Size(77, 23);
            partialClassTb1.TabIndex = 0;
            // 
            // Form8SyntaxAdvanced
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form8SyntaxAdvanced";
            Text = "Form8SyntaxAdvanced";
            Load += Form8SyntaxAdvanced_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox enumeratorRichTB;
        private GroupBox groupBox2;
        private TextBox partialClassTb3;
        private Button partialClassBtn;
        private TextBox partialClassTb2;
        private ComboBox partialClassCB;
        private TextBox partialClassTb1;
    }
}