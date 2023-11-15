namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Computer Science");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Data Science");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Electrical Engineering & Computer Sciences");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("UC Berkeley", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.btnClickThis = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.linklblContribute = new System.Windows.Forms.LinkLabel();
            this.lblCampusAndMajor = new System.Windows.Forms.Label();
            this.lblDescriptionClasses = new System.Windows.Forms.Label();
            this.chbxTakenClasses = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(580, 594);
            this.btnClickThis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(219, 43);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Submit";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(40, 289);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "cndUCBComputerScience";
            treeNode1.Text = "Computer Science";
            treeNode2.Name = "cndUCBDataScience";
            treeNode2.Text = "Data Science";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Electrical Engineering & Computer Sciences";
            treeNode4.Name = "ndUCB";
            treeNode4.Text = "UC Berkeley";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(1251, 110);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(573, 106);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 39);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "AssistHelper";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(421, 144);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(457, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Only available for IVC Computer Science Students! Contribute to the project : ";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // linklblContribute
            // 
            this.linklblContribute.AutoSize = true;
            this.linklblContribute.Location = new System.Drawing.Point(924, 144);
            this.linklblContribute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblContribute.Name = "linklblContribute";
            this.linklblContribute.Size = new System.Drawing.Size(34, 16);
            this.linklblContribute.TabIndex = 5;
            this.linklblContribute.TabStop = true;
            this.linklblContribute.Text = "here";
            // 
            // lblCampusAndMajor
            // 
            this.lblCampusAndMajor.AutoSize = true;
            this.lblCampusAndMajor.Location = new System.Drawing.Point(36, 271);
            this.lblCampusAndMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampusAndMajor.Name = "lblCampusAndMajor";
            this.lblCampusAndMajor.Size = new System.Drawing.Size(232, 16);
            this.lblCampusAndMajor.TabIndex = 6;
            this.lblCampusAndMajor.Text = "Please select your campus and major";
            this.lblCampusAndMajor.Click += new System.EventHandler(this.lblCampusAndMajor_Click);
            // 
            // lblDescriptionClasses
            // 
            this.lblDescriptionClasses.AutoSize = true;
            this.lblDescriptionClasses.Location = new System.Drawing.Point(37, 401);
            this.lblDescriptionClasses.Name = "lblDescriptionClasses";
            this.lblDescriptionClasses.Size = new System.Drawing.Size(1110, 32);
            this.lblDescriptionClasses.TabIndex = 8;
            this.lblDescriptionClasses.Text = "Please select the classes you have taken (If you have taken the honors version of" +
    " a class, please just select the normal version)  **** if you have completed IGE" +
    "TC, please select the option\r\n\r\n";
            this.lblDescriptionClasses.Click += new System.EventHandler(this.lblDescriptionClasses_Click);
            // 
            // chbxTakenClasses
            // 
            this.chbxTakenClasses.FormattingEnabled = true;
            this.chbxTakenClasses.Items.AddRange(new object[] {
            "IGETC",
            "MATH3A",
            "MATH3B",
            "MATH4A",
            "MATH26",
            "MATH24",
            "CS41",
            "CS36",
            "CS10",
            "CS37",
            "CS17/MATH17"});
            this.chbxTakenClasses.Location = new System.Drawing.Point(40, 420);
            this.chbxTakenClasses.Name = "chbxTakenClasses";
            this.chbxTakenClasses.Size = new System.Drawing.Size(1252, 123);
            this.chbxTakenClasses.TabIndex = 9;
            this.chbxTakenClasses.SelectedIndexChanged += new System.EventHandler(this.chbxTakenClasses_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 737);
            this.Controls.Add(this.chbxTakenClasses);
            this.Controls.Add(this.lblDescriptionClasses);
            this.Controls.Add(this.lblCampusAndMajor);
            this.Controls.Add(this.linklblContribute);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnClickThis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.LinkLabel linklblContribute;
        private System.Windows.Forms.Label lblCampusAndMajor;
        private System.Windows.Forms.Label lblDescriptionClasses;
        private System.Windows.Forms.CheckedListBox chbxTakenClasses;
    }
}

