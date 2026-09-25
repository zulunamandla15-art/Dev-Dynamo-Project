using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_Dynamo_Project
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // ===== 1. DECLARE ALL YOUR TEXTBOXES FIRST =====
            string fullName = txtFullNames.Text.Trim();
            string idNumber = txtIDNumber.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string cellphone = txtCellphone.Text.Trim();
            string businessName = txtBusiness.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirm.Text.Trim();
            int years = (int)nubHowlong.Value; // your NumericUpDown with 0





            // 1. SAVE the username & password so login can use it
            // Replace txtUsername, txtPassword, txtConfirm with your actual textbox names
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords don't match!");
                return;
            }

            Userstore.Username = txtUsername.Text;
            Userstore.Password = txtPassword.Text;

            MessageBox.Show("Registered! You can now login with: " + Userstore.Username);

            // 2. YOUR OLD CODE - this moves to next page - KEEP IT
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void frmRegistration_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFullNames_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCellphone_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtFullNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
        }

        private void txtIDNumber_Validating(object sender, CancelEventArgs e)
        {

            // First check: numbers only
            foreach (char c in txtIDNumber.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show(
                        "ID Number must contain numbers only.",
                        "Invalid ID Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIDNumber.Focus();
                    return;
                }
            }

            // Second check: exactly 13 digits
            if (txtIDNumber.Text.Length != 13)
            {
                MessageBox.Show(
                    "ID Number must contain exactly 13 digits.",
                    "Invalid ID Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIDNumber.Focus();
                return;
            }
        }

        private void txtCellphone_Validating(object sender, CancelEventArgs e)
        {

            // First check: numbers only
            foreach (char c in txtCellphone.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show(
                        "Cellphone Number must contain numbers only.",
                        "Invalid Cellphone Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCellphone.Focus();
                    return;
                }
            }

            // Second check: exactly 10 digits of Cellphone Number
            if (txtCellphone.Text.Length != 10)
            {
                MessageBox.Show(
                    "Cellphone Number must contain exactly 10 digits.",
                    "Invalid Cellphone Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCellphone.Focus();
                return;
            }
        }

        private void txtEmailAddress_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmailAddress.Text.Trim();

            // Check if the email is empty
            if (email == "")
            {
                MessageBox.Show(
                    "Please enter an email address.",
                    "Email Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmailAddress.Focus();
                return;
            }

            // Check for capital letters
            if (email != email.ToLower())
            {
                MessageBox.Show(
                    "Email addresses must not contain capital letters. Please enter your email address using lowercase letters.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmailAddress.Focus();
                return;
            }

            // Check the email format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show(
                    "Invalid email address. Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmailAddress.Focus();
                return;
            }
        }

        private void nubHowlong_Validating(object sender, CancelEventArgs e)
        {


            int years = (int)nubHowlong.Value;

            if (years < 4)
            {
                MessageBox.Show(
                    "Your business must have operated for at least 4 years. Your application will not be considered.\r\n.",
                    "Application Rejected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateOfBirth = dateTimePicker1.Value.Date;
            DateTime today = DateTime.Today;

            int age = today.Year - dateOfBirth.Year;

            // Check whether the birthday has happened this year
            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            if (age < 20)
            {
                MessageBox.Show(
                    "You must be at least 20 years old to apply.",
                    "Application Rejected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
        }

        private void txtFullNames_Validating(object sender, CancelEventArgs e)
        {
            
            string fullName = txtFullNames.Text.Trim();

            // Check if the name is empty
            if (fullName == "")
            {
                MessageBox.Show(
                    "Full name is required.",
                    "Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                e.Cancel = true;
                return;
            }

            // Check if the name contains only letters and spaces
            foreach (char c in fullName)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show(
                        "Please enter a valid full name. Numbers and special characters are not allowed.",
                        "Invalid Name",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    e.Cancel = true;
                    return;
                }
            }
        }

        private void radVehicleYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radVehicleYes.Checked)
            {
                radVehicleNo.Checked = false;
            }
        }

        private void radVehicleNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radVehicleNo.Checked)
            {
                radVehicleYes.Checked = false;
            }
        }

        private void radLicenseYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radLicenseYes.Checked)
            {
                radLicenseNo.Checked = false;
            }
        }

        private void radLicenseNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radLicenseNo.Checked)
            {
                radLicenseYes.Checked = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRecycling Recycling = new frmRecycling();
            Recycling.Show();
            this.Hide();
        }
    }
    
}

