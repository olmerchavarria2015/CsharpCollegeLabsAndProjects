//Filename Payroll.cs
//Written by Olmer Chavarria
//09-07-2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{

    class Program
    {
        //This program calculates the gross pay, deductions, and net pay
        //after asking user for information such as hourly rate and hours worked.
        const double FEDERAL_WITHHOLDING_PERCENT = 0.15;
        const double STATE_WITHHOLDING_PERCENT = 0.05;


        static void Main(string[] args)
        {
            string gp = "Gross pay:";
            string fwh = "Federal withholding:";
            string swh = "State withholding:";
            string np = "Net pay";        
            System.Console.Write("Enter your name: ");
            String name = System.Console.ReadLine();
            System.Console.Write("Social Security Number: ");
            String socialSecurity = System.Console.ReadLine();
            System.Console.Write("Hourly payrate: ");
            try
            {
                double hourlyPayrate = double.Parse(System.Console.ReadLine());
                System.Console.Write("Hours worked: ");
                double hoursWorked = double.Parse(System.Console.ReadLine());
                double grossPay = hourlyPayrate * hoursWorked;
                double federalWithdholding = grossPay * FEDERAL_WITHHOLDING_PERCENT;
                double stateWithholding = grossPay * STATE_WITHHOLDING_PERCENT;
                double netPay = ((grossPay - federalWithdholding)- stateWithholding);
                System.Console.WriteLine("Payroll Summary for: "+ name);
                System.Console.WriteLine("SSN: "+ socialSecurity);
                System.Console.WriteLine("You worked "+ hoursWorked +" hours at $"+ hourlyPayrate +" per hour");
                System.Console.WriteLine("{0 ,-21}{1,15:C2}",gp, grossPay);               //The Strings are formatted to display data giving the   
                System.Console.WriteLine("{0 ,-21}{1,15:C2}", fwh, federalWithdholding);  // program a more organized look.
                System.Console.WriteLine("{0 ,-21}{1,15:C2}", swh, stateWithholding);     //
                for (int i = 0; i < 36; i++) {
                    System.Console.Write("-");
                }
                System.Console.WriteLine(" ");
                System.Console.WriteLine("{0 ,-21}{1,15:C2}", np, netPay);
                
            }
            catch (Exception)
            {
                System.Console.WriteLine("Enter numbers only, Restart the program and try again. ");
                
                
            }
            System.Console.ReadLine();
        
            
         

        }
    }
}
