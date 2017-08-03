//Filename: InterestCalculator
//Written By: Olmer Chavarria
//09-23-2016
using System;
using System.Windows.Forms;

namespace InterestCalculator
{

    public partial class Form1 : Form
    {
        const int MONTHS_IN_YEAR = 12;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (errorLabel.Text.Length != 0)//deletes error label
            {
                errorLabel.Text = "";
            }
            try //error handling is done here
            {   
                //local variables are declared and later initialized from this point
                float initialBalance, monthlyInitialBalance, annualRate, years;
                initialBalance= float.Parse(initialBalanceBox.Text);
                annualRate = float.Parse(annIntrBox.Text);
                years= float.Parse(numOfYearsBox.Text);
                float annualCompoundRate = annualRate / 100;
                float monthlyCompoundRate = annualCompoundRate / MONTHS_IN_YEAR;
                float numberOfMonths = years * MONTHS_IN_YEAR;
                monthlyInitialBalance = initialBalance;

                //these loops add the calculated interest to the initial balance
                for (int i = 0; i < years; i++)//this loop compounds the interest by year
                {
                    float profit = initialBalance * annualCompoundRate;
                    initialBalance += profit;
                }
                for (int i = 0; i < numberOfMonths; i++)//this loops compounds the interest by month
                {
                    float profit = monthlyInitialBalance * monthlyCompoundRate;
                    monthlyInitialBalance += profit;
                }
                //the results are displayed
                intrCompAnnuallyLabel.Text = String.Format("{0:C2}", initialBalance);
                intrCompMonthlyLabel.Text = String.Format("{0:C2}", monthlyInitialBalance);
            }
            catch 
            {
                errorLabel.Text = "Error on input, try again";//Displays this if the input is other than numbers  
                intrCompAnnuallyLabel.Text = "";              // or the number has more than one decimal point.
                intrCompMonthlyLabel.Text = "";

            }


        }
    }
}
