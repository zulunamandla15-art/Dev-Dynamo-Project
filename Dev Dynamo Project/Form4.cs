using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_Dynamo_Project
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 1. DECLARE what user typed on reset form
            string newUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            // 2. Check empty
            if (newUsername == "" || newPassword == "")
            {
                MessageBox.Show("Please enter new username and new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. THIS IS THE MOST IMPORTANT PART - UPDATE EVERYWHERE
            // This overwrites the old Charlie2008 / 1234 that was saved during registration
            Userstore.Username = newUsername;
            Userstore.Password = newPassword;

            // 4. Show success and go back to Login
            MessageBox.Show("Password reseted successfully! Now login with your new details.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // This will automatically take you back to Login Form because we used ShowDialog()
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }
    }
}
