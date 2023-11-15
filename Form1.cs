using System;
using IronXL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // MAKES HIGHLIGHTING TREEVIEW STAY 
            treeView1.HideSelection = false;
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.DrawNode += (o, e) =>
            {
                if (!e.Node.TreeView.Focused && e.Node == e.Node.TreeView.SelectedNode)
                {
                    Font treeFont = e.Node.NodeFont ?? e.Node.TreeView.Font;
                    e.Graphics.FillRectangle(Brushes.Gray, e.Bounds);
                    ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, SystemColors.HighlightText, SystemColors.Highlight);
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
                }
                else
                    e.DrawDefault = true;
            };
            treeView1.MouseDown += (o, e) =>
            {
                TreeNode node = treeView1.GetNodeAt(e.X, e.Y);
                if (node != null && node.Bounds.Contains(e.X, e.Y))
                    treeView1.SelectedNode = node;
            };

        }


        public List<int> rowNumbers = new List<int>();
        public List<string> requiredClasses = new List<string>();
        public List<string> takenClasses = new List<string>();
        public List<string> ifTakenField = new List<string>();
        public List<string> ifRequiredField = new List<string>();

        private string getSelectedNode(object sender, EventArgs e)
        {
            treeView1.PathSeparator = ",";
            string node = treeView1.SelectedNode.FullPath; //SelectedNode.Text gets only the last node 
            return node;
            //exception handling idk how
        }

        private void getEverything(string node, List<int> rowNumbers, List<string> requiredClasses, List<string> ifRequiredField, List<string> ifTakenField)
        {
            WorkBook wb = WorkBook.Load("C:\\Users\\hanna\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\RequiredClasses.csv", fileFormat: ExcelFileFormat.XLSX, listDelimiter: ",");
            WorkSheet ws = wb.DefaultWorkSheet;
            wb.SaveAs("Csv_To_Excel.xlsx");
            DataTable dt = ws.ToDataTable(true);

            int rowNumber = 2;
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() + "," + row[1].ToString() == node)
                {
                    requiredClasses.Add(row[2].ToString());
                    ifRequiredField.Add(row[3].ToString());
                    ifTakenField.Add(row[4].ToString());
                    rowNumbers.Add(rowNumber);
                }
                rowNumber++;
            }
        } 
        



        // SUBMIT BUTTON
        public void btnClickThis_Click(object sender, EventArgs e)
        {
            // GETTING REQUIRED CLASSES //
            string node = getSelectedNode(sender, e);
            
            getEverything(node, rowNumbers, requiredClasses, ifRequiredField, ifTakenField);


            // GETTING TAKEN CLASSES //
            for (int i = 0; i <= (chbxTakenClasses.Items.Count-1); i++)
            {
                if (chbxTakenClasses.GetItemChecked(i))
                {
                    takenClasses.Add(chbxTakenClasses.Items[i].ToString());
                }
            }

            // DEBUGGING //
            /*for (int i = 0; i < requiredClasses.Count; i++)
            {
                Console.WriteLine(requiredClasses[i]);


            }
            for (int i = 0; i < takenClasses.Count; i++)
            {
                Console.WriteLine(takenClasses[i]);

            }*/

            // SETTING NEW PAGE // 
            Form2 nextForm = new Form2(rowNumbers, requiredClasses, takenClasses, ifRequiredField, ifTakenField);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();

        }

        
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblDescriptionClasses_Click(object sender, EventArgs e)
        {

        }

        private void lblCampusAndMajor_Click(object sender, EventArgs e)
        {

        }

        private void chbxTakenClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



