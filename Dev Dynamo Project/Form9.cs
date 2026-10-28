using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            else
            {
                MessageBox.Show("Bank details are successfully saved.");

                lblPaymentStatus.Text = "Payment Status: Pending";
            }
            string folderPath = @"C:\Users\Makro\OneDrive\Desktop\SMME Bank Details";
            string filePath = Path.Combine(folderPath, "SMME Bank Details.txt");

            string bank = cmbBank.Text;
            string accountHolder = txtAccountHolder.Text;
            string accountNumber = txtAccountNumber.Text;
            string accountType = cmbAccountType.Text;

            string paymentDetails =
                "Bank: " + bank + Environment.NewLine +
                "Account Holder Name: " + accountHolder + Environment.NewLine +
                "Account Number: " + accountNumber + Environment.NewLine +
                "Account Type: " + accountType + Environment.NewLine +
                "----------------------------------";

            File.AppendAllText(filePath, paymentDetails + Environment.NewLine);

            

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

        private void cmbBank_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbBank.Text))
            {
                MessageBox.Show("Please select bank type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                cmbBank.Focus();
            }
        }

        private void txtAccountHolder_Validating(object sender, CancelEventArgs e)
        {
            string name = txtAccountHolder.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter Account Holder Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                txtAccountHolder.Focus();
                return;
            }

        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountHolder_Validating_1(object sender, CancelEventArgs e)
        {
            string name = txtAccountHolder.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter Account Holder Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                txtAccountHolder.Focus();
                return;
            }

            // AFTER you are done writing - check if there's numbers or special chars
            if (!Regex.IsMatch(name, @"^[A-Za-z ]+$"))
            {
                MessageBox.Show("Account Holder Name must contain letters only. No numbers or special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                txtAccountHolder.Focus();
                return;
            }
        }

        private void cmbBank_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbBank.Text))
            {
                MessageBox.Show("Please select bank type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                cmbBank.Focus();
            }
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            string acc = txtAccountNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(acc))
            {
                MessageBox.Show("Please enter Account Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                txtAccountNumber.Focus();
                return;
            }
            if (!Regex.IsMatch(acc, @"^[0-9]{10,12}$"))
            {
                MessageBox.Show("Invalid Account Number. It must be 10 to 12 digits only. No letters or special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                txtAccountNumber.Focus();
            }

        }

        private void cmbAccountType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbAccountType.Text))
            {
                MessageBox.Show("Please select Account Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                cmbAccountType.Focus();
            }
        }

       
        private void txtAccountHolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

    }

}

