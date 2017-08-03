using System.Windows.Forms;

namespace BankingApplication
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

        }
        public string LabelText//this getter and setter allow this label to be accessed froma the main form.
        {
            get
            {
                return this.reportOuputLabel.Text;
            }
            set
            {
                this.reportOuputLabel.Text = value;
            }
        }
    }
}
