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
using System.IO;

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
            // Getting Values from Texbox//
            string fullName = txtFullNames.Text.Trim();
            string idNumber = txtIDNumber.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string cellphone = txtCellphone.Text.Trim();
            string businessName = txtBusiness.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirm.Text.Trim();
            int years = (int)nubHowlong.Value; //  NumericUpDown with 0


            string vehicle;
            if (radVehicleYes.Checked)
            {
                vehicle = "Yes";
            }
            else
            {
                vehicle = "No";
            }

            //  Checking if the applicant has License or not
            string License;
            if (radLicenseYes.Checked)
            {
                License = "Yes";
            }
            else
            {
                License = "No";
            }

            //Checking if the user left spaces on each of these required field then pops a message if one of these was left blank
            if (fullName == "" ||
                idNumber == "" ||
                email == "" ||
                cellphone == "" ||
                businessName == "" ||
                username == "" ||
                password == "" ||
                confirmPassword == "" ||
                years == 0)


            {
                MessageBox.Show("Please fill in all required fileds!!!!");
                return;
            }
            //Opening a folder to save all applicants information

            StreamWriter writer = new StreamWriter("SMME_Registration.txt ", true);
            using (writer)
            {
                //Saving application information to that "SMME_Registration" folder

                writer.WriteLine("==================================================");
                writer.WriteLine("Applicant");
                writer.WriteLine("===================================================");
                writer.WriteLine("Full Names:\t\t\t" + fullName);
                writer.WriteLine("ID Number:\t\t\t" + idNumber);
                writer.WriteLine("Year Born:\t\t\t" + dateTimePicker1.Text);
                writer.WriteLine("Email Address:\t\t" + email);
                writer.WriteLine("Cellphone Number:\t" + cellphone);
                writer.WriteLine("Business Name:\t\t" + businessName);
                writer.WriteLine("Username\t\t\t" + username);
                writer.WriteLine("Password\t\t\t" + password);



                // Saving  the username & password so login can use it//

                if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Passwords don't match!");
                    return;
                }

                Userstore.Username = txtUsername.Text;
                Userstore.Password = txtPassword.Text;

                MessageBox.Show("You've Sucessfully Registered");

                // 2. OLD CODE - this moves to next page - KEEP IT
                frmLogin Login = new frmLogin();
                Login.Show();
                this.Hide();
            }
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

            //Checking if is it numbers only entered or not nif not gives warning soon as tries to move to the next button//
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

            //Checking if the user entered exactly 13 digit needed or more or less//
            string idNumber = txtIDNumber.Text.Trim();
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

            // checking if is it numbers entered or not
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

            // Checking exactly 10 digits of Cellphone Number
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

            // Check if the email is empty and pop up message 
            if (email == "")
            {
                MessageBox.Show("Please enter an email address");
                return;
            }

            // Checking for capital letters on email entered
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

            // Checking  the email format
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

            //Checking if the applicants met the application years of eperating requirements
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
            string idNumber = txtIDNumber.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dateOfBirth.Year;

            // If birthday has not happened yet this year
            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            if (age < 20)
            {
                MessageBox.Show(
                    "Applicant unsuccessful. You are under age.",
                    "Application Unsuccessful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Prevent the user from moving to the next field
                e.Cancel = true;
            }
            string idYear = idNumber.Substring(0, 2);
            string idMonth = idNumber.Substring(2, 2);
            string idDay = idNumber.Substring(4, 2);

            int twoDigitYear = int.Parse(idYear);
            int fullYear;

            if (twoDigitYear <= int.Parse(DateTime.Now.ToString("yy")))
            {
                fullYear = 2000 + twoDigitYear;
            }
            else
            {
                fullYear = 1900 + twoDigitYear;
            }

            // Check YEAR, MONTH and DAY
            if (dateOfBirth.Year != fullYear ||
                dateOfBirth.Month != int.Parse(idMonth) ||
                dateOfBirth.Day != int.Parse(idDay))
            {
                MessageBox.Show(
                    "ID number and date of birth do not match. Please go back and correct your information.",
                    "Invalid Date of Birth",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Cancel = true;
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

            // Check if the name contains only letters and spaces no specialn characters needed
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
          string password = txtPassword.Text;

            // Check if password has at least 8 characters
            if (password.Length < 8)
            {
                MessageBox.Show("Password must contain at least 8 characters");
                e.Cancel = true;
                return;
            }

            // Checking password requirements
            bool hasCapital = false;
            bool hasNumber = false;
            bool hasSpecial = false;

            foreach (char character in password)
            {
                if (char.IsUpper(character))
                {
                    hasCapital = true;
                }

                if (char.IsDigit(character))
                {
                    hasNumber = true;
                }

                if (!char.IsLetterOrDigit(character))
                {
                    hasSpecial = true;
                }
            }

            // Check if any requirement is missing
            if (!hasCapital || !hasNumber || !hasSpecial)
            {
                MessageBox.Show(
                    "Password must contain:\n" +
                    "At least 8 characters\n" +
                    "At least one capital letter\n" +
                    "At least one number\n" +
                    "At least one special character"
                );

                
                return;
            }

           
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}









