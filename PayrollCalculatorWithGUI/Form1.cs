//Filename PayrollGUI
//Written by: Olmer Chavarria
//09-13-2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    //This program demostrates the use of Forms in Visual Studio
    //it is also the graphical equivalent of console payroll
    public partial class Payroll : Form
    {
        //Declaring constants and variables as global
        const double FEDERAL_WITHHOLDING_PERCENT = 0.15;
        const double STATE_WITHHOLDING_PERCENT = 0.05;
        float payrate;
        float hoursworked;
        float grosspay;
        double federalwithhold;
        double statewithhold;
        double netpay;
        public Payroll()
        {
            InitializeComponent();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!npLabel.Text.Equals(Color.Black))
                {
                    npLabel.ForeColor = Color.Black;
                }
                //varible initialization
                //Parsing text to numbers
                payrate = float.Parse(payRateTextBox.Text);
                hoursworked = float.Parse(hoursWorkedTextBox.Text);
                grosspay = payrate * hoursworked;
                federalwithhold = grosspay * FEDERAL_WITHHOLDING_PERCENT;
                statewithhold = grosspay * STATE_WITHHOLDING_PERCENT;
                netpay = grosspay - (federalwithhold + statewithhold);

                //Formatting output
                gpLabel.Text = String.Format("{0:C2}",grosspay);
                fwLabel.Text = String.Format("{0:C2}", federalwithhold);
                swLabel.Text = String.Format("{0:C2}", statewithhold);
                npLabel.Text = String.Format("{0:C2}", netpay);

            }
            //catching input errors
            catch
            {
                npLabel.ForeColor = Color.Red;
                npLabel.Text = "Number only,one dot";
                
            }

        }
    }
}
