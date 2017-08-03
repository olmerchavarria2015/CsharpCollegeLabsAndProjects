//*************************************************************************************************
//Written by: Olmer A, Chavarria
//ITSE-2453-53400 
//Learning Activity 03 
// 04/15/2017
// The purpose of this program is to demonstrate inheritance, base classes or super classes and derived classes or child classes. 
//  
//*************************************************************************************************
using static System.Console;
namespace DemoLoan
{
    class demoLoan2
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan();
            CarLoan aCarLoan = new CarLoan();
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoanAmount = 1000.00;
            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoanAmount = 20000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;

            WriteLine("Loan #{0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));
            WriteLine("Loan #{0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
            WriteLine("	Loan #{0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);

            ReadLine();
        }
    }
    class Loan //Base class or super class
    {
        public const double MINIMUM_LOAN = 5000;
        protected double loanAmount;
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount
        {
            set
            {
                if (value < MINIMUM_LOAN)
                    loanAmount = MINIMUM_LOAN;
                else loanAmount = value;
            }
            get
            {
                return loanAmount; 
                
            }
        }
    }

    class CarLoan : Loan //Derived class or child class.  This class inherits from Loan class
    {

        public new int LoanNumber //overrides the Base getter and setter
        {
            get
            {
                return base.LoanNumber;
            }
            set
            {
                if ((value < LOWEST_INVALID_NUM))
                    base.LoanNumber = value;                      //overrides the value of "LoanNumber" found on the base class
                  
                else
                {
                    base.LoanNumber = value % LOWEST_INVALID_NUM; //overrides the value of "LoanNumber" found on the base class
                }

            }
        }

        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;
        private int year;
        public int Year {
            set
            {
                if (value < EARLIEST_YEAR)
                {

                    year = value;
                    loanAmount = 0;
                    

                }
                else
                    year = value;
               
            }
            get
            {
                return year;
            }



        }
        public string Make { get; set; }
    }

    
}
