namespace CharsForms
{
    partial class Form16Registry
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
            TreeNode treeNode6 = new TreeNode("My Computer");
            rtbRegistry = new RichTextBox();
            createSubKeyBtn = new Button();
            rtbUpdateSubKey = new RichTextBox();
            hardwareSubKeyBtn = new Button();
            editSubKeyBtn = new Button();
            deleteSubKeyBtn = new Button();
            deleteSubKeyTree = new Button();
            deleteSubKeyValue = new Button();
            treeViewRegistry = new TreeView();
            groupBox1 = new GroupBox();
            propertyLabel = new Label();
            label5 = new Label();
            createKeyBtn = new Button();
            refreshBtn = new Button();
            extendedCharsRb = new RadioButton();
            charsRb = new RadioButton();
            nodeValueTb = new TextBox();
            nodeItemTb = new TextBox();
            nodeNameTb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            deleteConfigItemBtn = new Button();
            displayConfigItemBtn = new Button();
            itemNameTb = new TextBox();
            createConfigItemBtn = new Button();
            label4 = new Label();
            groupBox3 = new GroupBox();
            tryBtn = new Button();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // rtbRegistry
            // 
            rtbRegistry.Location = new Point(12, 12);
            rtbRegistry.Name = "rtbRegistry";
            rtbRegistry.Size = new Size(241, 374);
            rtbRegistry.TabIndex = 0;
            rtbRegistry.Text = "";
            // 
            // createSubKeyBtn
            // 
            createSubKeyBtn.Location = new Point(301, 252);
            createSubKeyBtn.Name = "createSubKeyBtn";
            createSubKeyBtn.Size = new Size(206, 22);
            createSubKeyBtn.TabIndex = 2;
            createSubKeyBtn.Text = "Create SubKey";
            createSubKeyBtn.UseVisualStyleBackColor = true;
            createSubKeyBtn.Click += createSubKeyBtn_Click;
            // 
            // rtbUpdateSubKey
            // 
            rtbUpdateSubKey.Location = new Point(283, 12);
            rtbUpdateSubKey.Name = "rtbUpdateSubKey";
            rtbUpdateSubKey.Size = new Size(247, 188);
            rtbUpdateSubKey.TabIndex = 3;
            rtbUpdateSubKey.Text = "";
            // 
            // hardwareSubKeyBtn
            // 
            hardwareSubKeyBtn.Location = new Point(301, 224);
            hardwareSubKeyBtn.Name = "hardwareSubKeyBtn";
            hardwareSubKeyBtn.Size = new Size(206, 22);
            hardwareSubKeyBtn.TabIndex = 4;
            hardwareSubKeyBtn.Text = "Display SubKey";
            hardwareSubKeyBtn.UseVisualStyleBackColor = true;
            hardwareSubKeyBtn.Click += hardwareSubKeyBtn_Click;
            // 
            // editSubKeyBtn
            // 
            editSubKeyBtn.Location = new Point(301, 280);
            editSubKeyBtn.Name = "editSubKeyBtn";
            editSubKeyBtn.Size = new Size(206, 22);
            editSubKeyBtn.TabIndex = 5;
            editSubKeyBtn.Text = "Edit SubKey";
            editSubKeyBtn.UseVisualStyleBackColor = true;
            editSubKeyBtn.Click += editSubKeyBtn_Click;
            // 
            // deleteSubKeyBtn
            // 
            deleteSubKeyBtn.Location = new Point(301, 308);
            deleteSubKeyBtn.Name = "deleteSubKeyBtn";
            deleteSubKeyBtn.Size = new Size(206, 22);
            deleteSubKeyBtn.TabIndex = 6;
            deleteSubKeyBtn.Text = "Delete SubKey";
            deleteSubKeyBtn.UseVisualStyleBackColor = true;
            deleteSubKeyBtn.Click += deleteSubKeyBtn_Click;
            // 
            // deleteSubKeyTree
            // 
            deleteSubKeyTree.Location = new Point(301, 336);
            deleteSubKeyTree.Name = "deleteSubKeyTree";
            deleteSubKeyTree.Size = new Size(206, 22);
            deleteSubKeyTree.TabIndex = 7;
            deleteSubKeyTree.Text = "Delete SubKey Tree";
            deleteSubKeyTree.UseVisualStyleBackColor = true;
            deleteSubKeyTree.Click += deleteSubKeyTree_Click;
            // 
            // deleteSubKeyValue
            // 
            deleteSubKeyValue.Location = new Point(301, 364);
            deleteSubKeyValue.Name = "deleteSubKeyValue";
            deleteSubKeyValue.Size = new Size(206, 22);
            deleteSubKeyValue.TabIndex = 8;
            deleteSubKeyValue.Text = "Delete SubKey Value";
            deleteSubKeyValue.UseVisualStyleBackColor = true;
            deleteSubKeyValue.Click += deleteSubKeyValue_Click;
            // 
            // treeViewRegistry
            // 
            treeViewRegistry.Location = new Point(569, 12);
            treeViewRegistry.Name = "treeViewRegistry";
            treeNode6.Name = "Node0";
            treeNode6.Text = "My Computer";
            treeViewRegistry.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeViewRegistry.Size = new Size(216, 368);
            treeViewRegistry.TabIndex = 9;
            treeViewRegistry.AfterSelect += treeViewRegistry_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(propertyLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(createKeyBtn);
            groupBox1.Controls.Add(refreshBtn);
            groupBox1.Controls.Add(extendedCharsRb);
            groupBox1.Controls.Add(charsRb);
            groupBox1.Controls.Add(nodeValueTb);
            groupBox1.Controls.Add(nodeItemTb);
            groupBox1.Controls.Add(nodeNameTb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(801, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 215);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Nodes";
            // 
            // propertyLabel
            // 
            propertyLabel.AutoSize = true;
            propertyLabel.Location = new Point(107, 28);
            propertyLabel.Name = "propertyLabel";
            propertyLabel.Size = new Size(52, 15);
            propertyLabel.TabIndex = 11;
            propertyLabel.Text = "Property";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 28);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "Nodes";
            // 
            // createKeyBtn
            // 
            createKeyBtn.Location = new Point(229, 184);
            createKeyBtn.Name = "createKeyBtn";
            createKeyBtn.Size = new Size(75, 23);
            createKeyBtn.TabIndex = 9;
            createKeyBtn.Text = "Create Key";
            createKeyBtn.UseVisualStyleBackColor = true;
            createKeyBtn.Click += createKeyBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(46, 184);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(75, 23);
            refreshBtn.TabIndex = 8;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // extendedCharsRb
            // 
            extendedCharsRb.AutoSize = true;
            extendedCharsRb.Location = new Point(185, 156);
            extendedCharsRb.Name = "extendedCharsRb";
            extendedCharsRb.Size = new Size(107, 19);
            extendedCharsRb.TabIndex = 7;
            extendedCharsRb.TabStop = true;
            extendedCharsRb.Text = "Extended Chars";
            extendedCharsRb.UseVisualStyleBackColor = true;
            extendedCharsRb.CheckedChanged += extendedCharsRb_CheckedChanged;
            // 
            // charsRb
            // 
            charsRb.AutoSize = true;
            charsRb.Location = new Point(53, 156);
            charsRb.Name = "charsRb";
            charsRb.Size = new Size(55, 19);
            charsRb.TabIndex = 6;
            charsRb.TabStop = true;
            charsRb.Text = "Chars";
            charsRb.UseVisualStyleBackColor = true;
            charsRb.CheckedChanged += charsRb_CheckedChanged;
            // 
            // nodeValueTb
            // 
            nodeValueTb.Location = new Point(107, 127);
            nodeValueTb.Name = "nodeValueTb";
            nodeValueTb.Size = new Size(197, 23);
            nodeValueTb.TabIndex = 5;
            // 
            // nodeItemTb
            // 
            nodeItemTb.Location = new Point(107, 95);
            nodeItemTb.Name = "nodeItemTb";
            nodeItemTb.Size = new Size(197, 23);
            nodeItemTb.TabIndex = 4;
            // 
            // nodeNameTb
            // 
            nodeNameTb.Location = new Point(107, 60);
            nodeNameTb.Name = "nodeNameTb";
            nodeNameTb.Size = new Size(197, 23);
            nodeNameTb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 127);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Key Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 95);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Key Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Key Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteConfigItemBtn);
            groupBox2.Controls.Add(displayConfigItemBtn);
            groupBox2.Controls.Add(itemNameTb);
            groupBox2.Controls.Add(createConfigItemBtn);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(801, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 130);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Config Key";
            // 
            // deleteConfigItemBtn
            // 
            deleteConfigItemBtn.Location = new Point(249, 75);
            deleteConfigItemBtn.Name = "deleteConfigItemBtn";
            deleteConfigItemBtn.Size = new Size(117, 23);
            deleteConfigItemBtn.TabIndex = 4;
            deleteConfigItemBtn.Text = "Delete Item";
            deleteConfigItemBtn.UseVisualStyleBackColor = true;
            deleteConfigItemBtn.Click += deleteConfigItemBtn_Click;
            // 
            // displayConfigItemBtn
            // 
            displayConfigItemBtn.Location = new Point(134, 75);
            displayConfigItemBtn.Name = "displayConfigItemBtn";
            displayConfigItemBtn.Size = new Size(109, 23);
            displayConfigItemBtn.TabIndex = 3;
            displayConfigItemBtn.Text = "Display Item";
            displayConfigItemBtn.UseVisualStyleBackColor = true;
            displayConfigItemBtn.Click += displayConfigItemBtn_Click;
            // 
            // itemNameTb
            // 
            itemNameTb.Location = new Point(99, 29);
            itemNameTb.Name = "itemNameTb";
            itemNameTb.Size = new Size(205, 23);
            itemNameTb.TabIndex = 2;
            // 
            // createConfigItemBtn
            // 
            createConfigItemBtn.Location = new Point(19, 75);
            createConfigItemBtn.Name = "createConfigItemBtn";
            createConfigItemBtn.Size = new Size(109, 23);
            createConfigItemBtn.TabIndex = 1;
            createConfigItemBtn.Text = "Create Item";
            createConfigItemBtn.UseVisualStyleBackColor = true;
            createConfigItemBtn.Click += createConfigItemBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 30);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 0;
            label4.Text = "Item name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tryBtn);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(12, 421);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(392, 168);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Software Trial Example";
            // 
            // tryBtn
            // 
            tryBtn.Location = new Point(223, 92);
            tryBtn.Name = "tryBtn";
            tryBtn.Size = new Size(75, 23);
            tryBtn.TabIndex = 1;
            tryBtn.Text = "Try Now(&Q)";
            tryBtn.UseVisualStyleBackColor = true;
            tryBtn.Click += tryBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 56);
            label6.Name = "label6";
            label6.Size = new Size(181, 15);
            label6.TabIndex = 0;
            label6.Text = "You can try the software 30 times";
            // 
            // button1
            // 
            button1.Location = new Point(569, 441);
            button1.Name = "button1";
            button1.Size = new Size(305, 23);
            button1.TabIndex = 13;
            button1.Text = "Speed Up shutdown and turning on Computer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 491);
            button2.Name = "button2";
            button2.Size = new Size(305, 23);
            button2.TabIndex = 14;
            button2.Text = "Speed Up rate of refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(569, 542);
            button3.Name = "button3";
            button3.Size = new Size(305, 23);
            button3.TabIndex = 15;
            button3.Text = "Speed Up Menu display";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form16Registry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 626);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(treeViewRegistry);
            Controls.Add(deleteSubKeyValue);
            Controls.Add(deleteSubKeyTree);
            Controls.Add(deleteSubKeyBtn);
            Controls.Add(editSubKeyBtn);
            Controls.Add(hardwareSubKeyBtn);
            Controls.Add(rtbUpdateSubKey);
            Controls.Add(createSubKeyBtn);
            Controls.Add(rtbRegistry);
            Name = "Form16Registry";
            Text = "Form16Registry";
            Load += Form16Registry_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbRegistry;
        private Button createSubKeyBtn;
        private RichTextBox rtbUpdateSubKey;
        private Button hardwareSubKeyBtn;
        private Button editSubKeyBtn;
        private Button deleteSubKeyBtn;
        private Button deleteSubKeyTree;
        private Button deleteSubKeyValue;
        private TreeView treeViewRegistry;
        private GroupBox groupBox1;
        private RadioButton extendedCharsRb;
        private RadioButton charsRb;
        private TextBox nodeValueTb;
        private TextBox nodeItemTb;
        private TextBox nodeNameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button refreshBtn;
        private Button createKeyBtn;
        private GroupBox groupBox2;
        private TextBox itemNameTb;
        private Button createConfigItemBtn;
        private Label label4;
        private Button displayConfigItemBtn;
        private Button deleteConfigItemBtn;
        private Label label5;
        private Label propertyLabel;
        private GroupBox groupBox3;
        private Label label6;
        private Button tryBtn;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}