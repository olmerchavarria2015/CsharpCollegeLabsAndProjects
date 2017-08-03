//Filename: TaxCalculator
//Written by: Olmer Chavarria
//10-02-2016
//I have included and extra array with the rates for tax as married,
// also an extra method for calculating tax for married couples
//  to earn 10 extrapoints.
using System;
using System.Windows.Forms;

namespace Income_Tax
{
    public partial class Form1 : Form
    {
        


        double[,] singleArray =
            { { .10, .15, .25, .28, .33, .35, .396 },
            { 0.0, 9275.0, 37650.0, 91150.0, 190150.0, 413350.0, 415050.0 },
            { 0.0, 927.50, 5183.75, 18558.75, 46278.75, 119934.75, 120529.75 }
        };
        double[,] marriedArray =
            { { .10, .15, .25, .28, .33, .35, .396 },
            { 0.0, 18550.0, 75300.0, 151900.0, 231450.0, 413350.0, 466950.0 },
            { 0.0, 1855.0, 10367.50, 29517.50, 51791.50, 111818.50, 130578.50 }
        };
        public Form1()
        {
            InitializeComponent();
        }
        public void calculateMarriedTax() //calculates married couples income tax
        {
            double standardDeduction = 6300;
            double exCeption = 4050;
            double totalIncome = 0;
            double adjustedGrossIncome = 0;
            double dependents = 2;                 //number of the dependents for wife and husband
            double taxableIncomeRate = 0;
            double taxDueToIncome = 0;
            double incomeThreshold = 0;
            double incomeTax = 0;
            try
            {
                if (!(errorLabel.Text.Length == 0)) { errorLabel.Text = ""; }

                dependents = dependents + double.Parse(dependentsTBox.Text); //add dependents other than self
                totalIncome = double.Parse(totalIncomeTBox.Text);
                adjustedGrossIncome = totalIncome - (exCeption * dependents) - standardDeduction;
                if (adjustedGrossIncome > 0)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (adjustedGrossIncome >= marriedArray[1, i])//adjustedGrossIncome is used here to find the other rates
                        {
                            taxableIncomeRate = marriedArray[0, i];
                            incomeThreshold = marriedArray[1, i];
                            taxDueToIncome = marriedArray[2, i];
                        }
                        else { continue; }
                    }
                    incomeTax = taxDueToIncome + (adjustedGrossIncome - incomeThreshold) * taxableIncomeRate;
                    goiOutputLabel.Text = adjustedGrossIncome.ToString("c2");
                    incomeTaxOutputLabel.Text = incomeTax.ToString("c2");

                }
                else
                {
                    incomeTax += taxDueToIncome + (totalIncome - incomeThreshold) * taxableIncomeRate;
                    goiOutputLabel.Text = adjustedGrossIncome.ToString("c2");
                    incomeTaxOutputLabel.Text = "$0.00";

                }





            }
            catch
            {
                errorLabel.Text = "ERROR ON INPUT";
                //throw;
            }
        }
        public void calculateTax() //calculates single's income tax
        {
            //formulas
            //Compute the Adjusted Gross Income(AGI) = totalIncome - (exCeption * dependents) - standardDeduction 
            //The tax is = taxDueToIncome + (adjustedGrossIncome - incomeThreshold) * taxableIncomeRate

            double standardDeduction = 6300;
            double exCeption = 4050;
            double totalIncome = 0;
            double adjustedGrossIncome = 0;
            double dependents = 1;                  //number of dependents for self
            double taxableIncomeRate = 0;
            double taxDueToIncome = 0;
            double incomeThreshold = 0;
            double incomeTax = 0;
            try
            {
                if (!(errorLabel.Text.Length == 0)) { errorLabel.Text = ""; }

                dependents = dependents + double.Parse(dependentsTBox.Text); //
                totalIncome = double.Parse(totalIncomeTBox.Text);
                adjustedGrossIncome = totalIncome - (exCeption * dependents) - standardDeduction;
                if (adjustedGrossIncome > 0)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (adjustedGrossIncome >= singleArray[1, i]) //adjustedGrossIncome is used here to find the other rates 
                        {
                            taxableIncomeRate = singleArray[0, i];
                            incomeThreshold = singleArray[1, i];
                            taxDueToIncome = singleArray[2, i];
                        }
                        else { continue; }
                    }
                    incomeTax = taxDueToIncome + (adjustedGrossIncome - incomeThreshold) * taxableIncomeRate;
                    goiOutputLabel.Text = adjustedGrossIncome.ToString("c2");
                    incomeTaxOutputLabel.Text = incomeTax.ToString("c2");

                }
                else
                {
                    incomeTax += taxDueToIncome + (totalIncome - incomeThreshold) * taxableIncomeRate;
                    goiOutputLabel.Text = adjustedGrossIncome.ToString("c2");
                    incomeTaxOutputLabel.Text = "$0.00";

                }





            }
            catch
            {
                errorLabel.Text = "ERROR ON INPUT";
                //throw;
            }
        }


        private void maritalStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (maritalStatusCheckBox.Checked && !marrieLabel.Visible)
            {
                marrieLabel.Visible = true;
            }
            else { marrieLabel.Visible = false; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (maritalStatusCheckBox.Checked) //checks if the marital status is checked
            {
                calculateMarriedTax();
            }
            else
            {

                calculateTax();
            }



        }
    }
}
