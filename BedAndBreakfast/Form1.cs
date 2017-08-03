//*************************************************************************************************
//Written by: Olmer A, Chavarria
//04/27/2017
//ITSE-2453-53400 
//Learning Activity 04 
// Using controls, form manipulation,and new form creation withing a program
//*************************************************************************************************

using System;
using System.Windows.Forms;

namespace BedAndBreakfast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void belleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAireCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                belleAireCheckBox.Checked = false;
            }
        }

        private void lincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (lincolnCheckBox.Checked)
            {
                LincolnForm lincolnForm = new LincolnForm();
                lincolnForm.ShowDialog();
                lincolnCheckBox.Checked = false;
            }

        }

        private void mealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastForm = new BreakfastOptionForm();
            breakfastForm.ShowDialog();
        }
    }
}
