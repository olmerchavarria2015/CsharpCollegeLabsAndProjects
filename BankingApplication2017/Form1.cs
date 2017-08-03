//***********************************************************************
//Filename:Bamking Application ..WORKING 
// Written by: Olmer Chavarria
// Date: 04/7/2017
// ITSE-2453-53400
// Lab: 5
// Description: This program is a Banking Application. It handles 19 accounts at once. 
//this application also demonstrates exception handling and the creation of custom exceptions.
//this application is now enhaced and demmostrates Abstract classes, Events , Delegates.
//new features: Prints reports about all the accounts, Perform monthly operation on account that meet some conditions
//prints report in a separated Form, Saves the program on a serial file.
//***********************************************************************

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;

namespace BankingApplication
{
    public partial class Form1 : Form
    {
        Account[] accounts = new Account[21];//an array of 20 Account objects. //index zero will not be used
        serialData[] dArray = new serialData[21];
        int maxAccounts = 0;                         //keeps control of how many accounts there are
        const string FILENAME = @"C:\Users\Admin\Desktop\ADV-C#2017\Data.ser";
        BinaryFormatter bFormatter = new BinaryFormatter();
        serialData inAccount;
        //checkingAccount dataCheckingAccount;
        //savingAccount dataSavingAccount;
        public Form1()
        {

            InitializeComponent();
            //this code loads the existing accounts into the progran.
            FileStream inFile;
            string filename = @"C:\Users\Admin\Desktop\ADV-C#2017\Data.ser";//path to the file contining the saved accounts.
            if (File.Exists(filename))//chesk if the file exist alredy, if it does not, creates a new one.
            {
                inFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
            }
            else
            {
                inFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            }
            while (inFile.Position < inFile.Length)//this loop reads the file.
            {
                inAccount = (serialData)bFormatter.Deserialize(inFile);//Deserialize the data from thr file and cast it into an serialData object.
                dArray[inAccount.accountNumber] = inAccount;
                if (inAccount.type.Equals("Checking"))//verifies whether the object belongs to a cheking or savings account.
                {
                    checkingRButton.Checked = true;
                }
                else
                {
                    savingsRButton.Checked = true;
                }
                seniorCheckBox.Checked = inAccount.senior;
                studentCheckBox.Checked = inAccount.student;

                createAccount(inAccount.accountNumber, inAccount.Balance,true);// a new Account object from the serialData.
                
            }
            inFile.Close();//closes the file
            outputLabel.Text = String.Format("{0} accounts loaded", maxAccounts);// displays how many accounts were loaded.
        }


        private void createAccountButton_Click(object sender, EventArgs e)//creates a new account when clicking the button.
        {
            if (outputLabel.ForeColor != Color.LimeGreen)
            {
                outputLabel.ForeColor = Color.LimeGreen;
            }
            createAccount(validateIdTBox(), validateAmount(),false);
        }

        private void executeButton_Click(object sender, EventArgs e)// executes the chosen action.
        {
            if (outputLabel.ForeColor != Color.LimeGreen)
            {
                outputLabel.ForeColor = Color.LimeGreen;
            }

            if (balanceRbutton.Checked)
            {
                balance();
            }
            else if (depositRbutton.Checked)
            {
                deposit();
            }
            else if (withdrawRbutton.Checked)
            {
                withDraw();
            }

        }

        public void createAccount(int AccountNumb, double initialBalance,bool bypass)
        {
            //every "if" estatement checks for every error posibility step by step. 
            
            if (AccountNumb != 0)
            {
                if (maxAccounts <=20)//keep the maximum of opened accounts to 20
                {
                    if (AccountNumb != -1 && accounts[AccountNumb] == null)
                    {
                        if (initialBalance >= 300)
                        {
                            if (checkingRButton.Checked || savingsRButton.Checked)
                            {
                                if (checkingRButton.Checked) { accounts[AccountNumb] = new checkingAccount(studentCheckBox.Checked); }
                                else if (savingsRButton.Checked) { accounts[AccountNumb] = new savingAccount(seniorCheckBox.Checked); }
                                if (!accounts[AccountNumb].active)
                                {
                                    
                                        
                                        EventListener listener = new EventListener(accounts[AccountNumb], label1);
                                        accounts[AccountNumb].active = true;
                                        accounts[AccountNumb].AccountNumber = AccountNumb;
                                        accounts[AccountNumb].Balance = initialBalance;

                                        addData(accounts[AccountNumb].AccountNumber, accounts[AccountNumb].Balance, accounts[AccountNumb].type,
                                            accounts[AccountNumb].senior, accounts[AccountNumb].student);
                                        if (!bypass)
                                        {
                                            serialize();
                                            outputLabel.Text = String.Format("{2} account# {0} Opened with a balance of {1:c}"
                                            , AccountNumb, accounts[AccountNumb].Balance, accounts[AccountNumb].type);
                                        }

                                        maxAccounts++;
                                        clearTBs();
                                    
                                    
                                }
                                else
                                {
                                    alertColor();
                                    outputLabel.Text = "This account is already active ";
                                } 
                            }
                            else { alertColor(); outputLabel.Text = "Choose type of account, Checking or Savings?"; }
                        }
                        else { alertColor(); outputLabel.Text = "Initial deposit must be $300 or greater"; }


                    }
                    else { alertColor(); outputLabel.Text = "This account number is not available "; }
                }
                else
                {
                    alertColor();
                    outputLabel.Text = "Maximum number of account exceeded";
                }
            }
        }
        public void balance()
        {
            //every "if" estatement checks for every error posibility
            int AccountNumber = validateIdTBox();
            if (AccountNumber != 0)
            {
                if (AccountNumber != -1)
                {
                    if (accounts[AccountNumber] != null)
                    {
                        outputLabel.Text = string.Format("Account {0} has a balance of {1:c}"
                            , AccountNumber, accounts[AccountNumber].Balance);
                    }
                    else { alertColor(); outputLabel.Text = "This account is not active yet"; }
                }
                else { alertColor(); outputLabel.Text = "enter a valid account number"; }
            }
        }
        public void deposit()
        {
            //every "if" estatement checks for every error posibility step by step
            int AccountNumber = validateIdTBox();

            if (AccountNumber != 0)
            {
                if (AccountNumber != -1)
                {
                    if (accounts[AccountNumber] != null)
                    {
                        double depositAmount = validateAmount();
                        if (depositAmount != 0)
                        {
                            if (depositAmount != -1)
                            {

                                accounts[AccountNumber].Balance = accounts[AccountNumber].Balance + depositAmount;
                                outputLabel.Text = String.Format("{2:c} deposited to Account# {0} \r\n and has now a balance of {1:c}", AccountNumber, accounts[AccountNumber].Balance, depositAmount);
                                addData(accounts[AccountNumber].AccountNumber, accounts[AccountNumber].Balance);
                                serialize();
                                clearTBs();

                            }
                            else { alertColor(); outputLabel.Text = "enter a valid account amount"; }
                        }
                    }
                    else { alertColor(); outputLabel.Text = "This account is not active yet"; }
                }
                else { alertColor(); outputLabel.Text = "enter a valid account number"; }
            }
        }
        public void withDraw()//A withdraw method which deducts an amount from the balance
        {
            //every "if" estatement checks for every error posibility
            int AccountNumber = validateIdTBox();

            if (AccountNumber != 0)
            {
                if (AccountNumber != -1)
                {
                    if (accounts[AccountNumber] != null)
                    {
                        double withdrawAmount = validateAmount();
                        if (withdrawAmount != 0)
                        {
                            if (withdrawAmount != -1)
                            {
                                try
                                {
                                    accounts[AccountNumber].Balance = accounts[AccountNumber].Balance - withdrawAmount;
                                    outputLabel.Text = String.Format("{2:c} withdrawn from Account# {0} \r\n and has now a balance of {1:c}"
                                        , AccountNumber, accounts[AccountNumber].Balance, withdrawAmount);
                                    addData(accounts[AccountNumber].AccountNumber, accounts[AccountNumber].Balance);
                                    serialize();
                                    clearTBs();
                                }
                                catch (Exception exc)
                                {
                                    alertColor();
                                    outputLabel.Text = exc.Message;
                                }
                            }
                            else { alertColor(); outputLabel.Text = "enter a valid account amount"; }
                        }
                    }
                    else { alertColor(); outputLabel.Text = "This account is not active yet"; }
                }
                else { alertColor(); outputLabel.Text = "enter a valid account number"; }
            }
        }


        public void clearTBs()//clears the textboxes after each transaction.
        {
            idTbox.Text = "";
            amountTbox.Text = "";
        }

        public int validateIdTBox()//validates the account number by checking if the number is not out of range.
        {
            int AccountId;
            try {
                AccountId = int.Parse(idTbox.Text);
                if (AccountId <= 0 || AccountId >20)
                {
                    return -1;           // retutn if number is out of bounds.
                }
                else { return AccountId; }

            } catch { alertColor(); outputLabel.Text = "Invalid ID entered. Please correct"; return 0; }//trigger by wrong format exception.
        }
        public double validateAmount()// verifies user entered a valid amount.
        {
            double amount;
            try
            {
                amount = double.Parse(amountTbox.Text);
                if (amount <= 0)
                {
                    return -1;
                } else { return amount; }


            } catch { alertColor(); outputLabel.Text = "Invalid format in the amount field. Please correct"; return 0; }
        }
        public void alertColor()//changes the label color to red when displaying alerts.
        {
            if (outputLabel.ForeColor != Color.Red)
            {
                outputLabel.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void endOfMonthButton_Click(object sender, EventArgs e)
        {
            checkingAccount account;//temporary holders for the Account objects.
            savingAccount svAccount;//
            for (int i = 1; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    if (accounts[i].type.Equals("Checking"))
                    {
                        account = (checkingAccount)accounts[i];     //casts Account object into the checking account object.
                        if (account.Balance < 1500)                   //charges fee to account if balance is less than $1500.
                            account.Balance -= account.fee;
                    }
                    else
                    {
                        svAccount = (savingAccount)accounts[i];     //casts Account object into the saving account object.
                        if (svAccount.Balance > 2500)   //pays interest if balance is more than 2500.
                            svAccount.Balance += ((svAccount.Balance * (svAccount.annualRate / 100)) / 12);
                    }
                }
            }
            outputLabel.Text = "End of the Month processing has completed";
        }

        private void reportButton_Click(object sender, EventArgs e)//prints a report of all the accounts in a separated form. 
        {
            if (outputLabel.ForeColor != Color.LimeGreen)
            {
                outputLabel.ForeColor = Color.LimeGreen;
            }
            string report = "";
            ReportForm reportForm = new ReportForm();// creates object of the new form
            
            for (int i = 1; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    report += String.Format("{2} acccount {0} has a balance of {1:c} \r\n", i, accounts[i].Balance, accounts[i].type);
                }
            }
            reportForm.LabelText = report;
            reportForm.ShowDialog();
        }
        void serialize()//serialData array to the file.
        {
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            for (int i = 1; i < dArray.Length; i++)
            {

                if (dArray[i] != null)
                {
                    bFormatter.Serialize(outFile, dArray[i]);
                }
            }
            outFile.Close();
        }
        void addData(int accNumber, double balance, string type, bool senior,bool student)//adds or modifies data to the serial data array
        {
            serialData temp;
            if (dArray[accNumber] != null)
            {
                dArray[accNumber].accountNumber = accNumber;
                dArray[accNumber].Balance = balance;
                dArray[accNumber].type = type;
                dArray[accNumber].senior = senior;
                dArray[accNumber].student = student;
            }
            else 
            {
                temp = new serialData();
                temp.accountNumber = accNumber;
                temp.Balance = balance;
                temp.type = type;
                temp.senior = senior;
                temp.student = student;
                dArray[accNumber] = temp;
            }
        }
        void addData(int accNumber, double balance)//variation of the avobe method used when entry already exist.
        {
           dArray[accNumber].Balance = balance;
        }

    }

    [Serializable]
    public class serialData//class containing  only serializable data.
    {
        public int accountNumber;
        public double Balance;
        public string type;
        public bool student;
        public bool senior;
    }

    public delegate void ChangedEventHandler(object sender, EventArgs e);
    public abstract class Account    // superclass.
    {
        public bool senior = false;
        public bool student = false;
        private double balance;
        public bool active = false;
        public string type;
        public int AccountNumber { get; set; }//accountID instance variable.
        public event ChangedEventHandler Changed;
        public double Balance  //decimal balance instance variable.
        {
            get  //Properties to get and set those instance variables
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    NegativeBalanceException nbe =
                          new NegativeBalanceException();
                    throw nbe;

                }
                else { balance = value; }
                OnChanged(EventArgs.Empty);
            }
        }
        private void OnChanged(EventArgs e)
        {
            Changed(this, e);
        }
    }
    class EventListener//custom event listener
    {
        Label lbl;
        
        private Account acct;
        public EventListener(Account account, Label label)
        {
            
            lbl = label;
            acct = account;
            acct.Changed += new ChangedEventHandler(AccountChanged);
        }
        private async void AccountChanged(object sender, EventArgs e)//notifies when an Account object has been accessed or changed.
        {
            
            lbl.Text = " Accounts object modified ";
            await Task.Delay(1500);//makes the text go away after a second in a half.
            lbl.Text = " ";

        }

    }

    
    public class checkingAccount : Account //inherits from superclass.
    {
       
        public double fee = 6.95;
        
        public checkingAccount(bool collegeStu)
        {
            type = "Checking";
            student = collegeStu;
            if (student)
            {
                fee = 3.95;
            }
        }
    }
    
    public class savingAccount : Account //inherits from superclass.
    {
        
        public double annualRate=1.5;
        
        public savingAccount(bool seniorCtz)
        {
            type = "Savings";
            senior = seniorCtz;
            if (senior)
            {
                annualRate = 3.5;
            }
        }
     
        
    }


    class NegativeBalanceException : Exception //Custom exception class.
    {
        private static string msg = "Amount is more than your account balance. Try again";
        public NegativeBalanceException() : base(msg) { }
    }
}
