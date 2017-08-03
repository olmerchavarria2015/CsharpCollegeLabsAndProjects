//Filename DailySpecial
//Written by Olmer Chavarria
//09-20-2016
using System;
using System.Windows.Forms;

namespace DailySpecial
{
    public partial class Form1 : Form
    {   
        //Creates an enumeration to represent the days of the week
        // and is later used on the switch.      
        enum Day   
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY,
            THURSDAY, FRIDAY, SATURDAY
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(dayBox.Text);
            string special;
            switch ((Day)day)//int day is cast to an enumeration value
            {
                case Day.SUNDAY:
                    special = "fried chicken";
                    break;
                case Day.MONDAY:
                    special = "Sorry - Close";
                    break;
                case Day.TUESDAY:
                case Day.WEDNESDAY:
                case Day.THURSDAY:
                    special = "meat loaf";
                    break;
                case Day.FRIDAY:
                    special = "fish fry";
                    break;
                case Day.SATURDAY:
                    special = "liver and onions";
                    break;
                default:
                    special = "invalid day";
                    break;   
     
             }
            outputLabel.Text = "Today's special is " + special;
        }
    }
}
