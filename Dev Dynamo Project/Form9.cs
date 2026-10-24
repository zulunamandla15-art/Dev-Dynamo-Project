using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_Dynamo_Project
{
    public partial class frmpay : Form
    {
        public frmpay()
        {
            InitializeComponent();
        }

        private void btnSaveBankDetails_Click(object sender, EventArgs e)
        {

            if (cmbBank.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your bank.");
            }
            else if (txtAccountHolder.Text == "")
            {
                MessageBox.Show("Please enter the account holder's name.");
            }
            else if (txtAccountNumber.Text == "")
            {
                MessageBox.Show("Please enter your account number.");
            }
            else if (cmbAccountType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your account type.");
            }
            else if (txtBranchCode.Text == "")
            {
                MessageBox.Show("Please enter your branch code.");
            }
            else
            {
                MessageBox.Show("Bank details entered successfully. Your payment is pending verification.");

                lblPaymentStatus.Text = "Payment Status: Pending";
            }
            string desktopPath = Environment.GetFolderPath(
            Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Bank details.txt");
            string bank = cmbBank.Text;
            string accountHolder = txtAccountHolder.Text;
            string accountNumber = txtAccountNumber.Text;
            string accountType = cmbAccountType.Text;
            string branchCode = txtBranchCode.Text;
            string paymentDetails =
                "Bank: " + bank + Environment.NewLine +
                "Account Holder Name: " + accountHolder + Environment.NewLine +
                "Account Number: " + accountNumber + Environment.NewLine +
                "Account Type: " + accountType + Environment.NewLine +
                "Branch Code: " + branchCode + Environment.NewLine +
                "----------------------------------------";
            File.AppendAllText(filePath,
                paymentDetails + Environment.NewLine);

            MessageBox.Show("Payment details saved successfully!");
        }
        

        private void Form9_Load(object sender, EventArgs e)
        {
            cmbBank.Items.Add("Capitec");
            cmbBank.Items.Add("FNB");
            cmbBank.Items.Add("Standard Bank");
            cmbBank.Items.Add("ABSA");
            cmbBank.Items.Add("Nedbank");
            cmbBank.Items.Add("TymeBank");

            cmbAccountType.Items.Add("Savings");
            cmbAccountType.Items.Add("Cheque / Current");

            lblPaymentStatus.Text = "Payment Status: Pending";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmRecycling home = new frmRecycling();
            home.Show();
            this.Hide();
        }
    }
    
}

