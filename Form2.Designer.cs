namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.linklblContribute = new System.Windows.Forms.LinkLabel();
            this.sampleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDatabaseDataSet = new WindowsFormsApp1.SampleDatabaseDataSet();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ClassField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequiredField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TakenField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(421, 144);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(457, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Only available for IVC Computer Science Students! Contribute to the project : ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(573, 106);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 39);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "AssistHelper";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // linklblContribute
            // 
            this.linklblContribute.AutoSize = true;
            this.linklblContribute.Location = new System.Drawing.Point(924, 144);
            this.linklblContribute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblContribute.Name = "linklblContribute";
            this.linklblContribute.Size = new System.Drawing.Size(34, 16);
            this.linklblContribute.TabIndex = 7;
            this.linklblContribute.TabStop = true;
            this.linklblContribute.Text = "here";
            // 
            // sampleDatabaseDataSetBindingSource
            // 
            this.sampleDatabaseDataSetBindingSource.DataSource = this.sampleDatabaseDataSet;
            this.sampleDatabaseDataSetBindingSource.Position = 0;
            // 
            // sampleDatabaseDataSet
            // 
            this.sampleDatabaseDataSet.DataSetName = "SampleDatabaseDataSet";
            this.sampleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassField,
            this.RequiredField,
            this.TakenField});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(329, 174);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(699, 279);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ClassField
            // 
            this.ClassField.Text = "";
            this.ClassField.Width = 150;
            // 
            // RequiredField
            // 
            this.RequiredField.Text = "";
            this.RequiredField.Width = 202;
            // 
            // TakenField
            // 
            this.TakenField.Text = "";
            this.TakenField.Width = 213;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WindowsFormsApp1.Program);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Schedule Builder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "GPA Calculator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 737);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.linklblContribute);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel linklblContribute;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSetBindingSource;
        private SampleDatabaseDataSet sampleDatabaseDataSet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ClassField;
        private System.Windows.Forms.ColumnHeader RequiredField;
        private System.Windows.Forms.ColumnHeader TakenField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}