using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public List<int> rowNumbers;
        public List<string> requiredClasses;
        public List<string> takenClasses;
        public List<string> ifRequiredField;
        public List<string> ifTakenField;


        public Form3(List<int> rowNumbersForm1, List<string> requiredClassesForm1, List<string> takenClassesForm1, List<string> ifRequiredFieldForm1, List<string> ifTakenFieldForm1)
        {
            InitializeComponent();

            // COPYING FORM1 DATA 
            rowNumbers = rowNumbersForm1;

            requiredClasses = requiredClassesForm1;
            takenClasses = takenClassesForm1;
            ifRequiredField = ifRequiredFieldForm1;
            ifTakenField = ifTakenFieldForm1;

            int untakenClasses = requiredClasses.Count - takenClasses.Count();
            label2.Hide();


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Show();
            decimal GPA = numericUpDown1.Value;
            if (GPA < 0) 
            {
                label2.Text = "Your GPA is less than 0?";
            }
            else
            {
                float neededResidentGPA = 2.4f;
                float neededNonResidentGPA = 2.8f;

                decimal result = GPA + (GPA / requiredClasses.Count - takenClasses.Count);

                // class1+class2+/numofClasss 

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
