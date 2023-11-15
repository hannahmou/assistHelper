using IronXL;
using System;
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
    public partial class Form2 : Form
    {
        public List<int> rowNumbers;
        public List<string> requiredClasses;
        public List<string> takenClasses;
        public List<string> ifRequiredField;
        public List<string> ifTakenField;


        public Form2(List<int> rowNumbersForm1, List<string> requiredClassesForm1, List<string> takenClassesForm1, List<string> ifRequiredFieldForm1, List<string> ifTakenFieldForm1)
        {
            InitializeComponent();

            // COPYING FORM1 DATA 
            rowNumbers = rowNumbersForm1;

            requiredClasses = requiredClassesForm1;
            takenClasses = takenClassesForm1;
            ifRequiredField = ifRequiredFieldForm1;
            ifTakenField = ifTakenFieldForm1;



            // setting taken classes into taken 
            for (int i = 0; i < takenClasses.Count; i++)
            {
                for (int j = 0; j < requiredClasses.Count; j++)
                {
                    Console.WriteLine("this is taken classes" + takenClasses[i]);
                    if (takenClasses[i] == requiredClasses[j])
                    {
                        Console.WriteLine(j);
                        ifTakenField[j] = "Taken";

                    }
                }

            }

            for (int i = 0; i < requiredClasses.Count; i++)
            {
                insertData(i);
            }
        }


        private void insertData(int i)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = requiredClasses[i].ToString();
            lvi.SubItems.Add(ifRequiredField[i]);
            lvi.SubItems.Add(ifTakenField[i]);
            listView1.Items.Add(lvi);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nextForm = new Form3(rowNumbers, requiredClasses, takenClasses, ifRequiredField, ifTakenField);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
