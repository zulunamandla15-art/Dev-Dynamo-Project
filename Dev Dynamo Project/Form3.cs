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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPassword ResetPassword= new frmResetPassword();
            ResetPassword.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Applications.txt");
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No user yet.Register first!");
            }
            // 1. First check username and password
            if (txtUsername.Text != Userstore.Username )
            {
                MessageBox.Show("Username does not match!");
                return;
            }
            if(txtPassword.Text != Userstore.Password)
            {
                MessageBox.Show("Password does not Match!");
                return;
            }

            // 2. If password correct, check which role they selected
            if (radSMME.Checked)
            {
                frmSMME smme = new frmSMME();
                smme.Show();
                this.Hide();
            }
            else if (radMunicipality.Checked)
            {
                // change Form1 to whatever your Municipality dashboard is called
                frmMunicipality Municipality = new frmMunicipality();
                Municipality.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select if you are SME Owner or Municipality");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRegistration Registration = new frmRegistration();
            Registration.Show();
            this.Hide();
        }

        private void radMunicipality_CheckedChanged(object sender, EventArgs e)
        {
            if (radMunicipality.Checked)
            {
                if (txtUsername.Text == "municipality" &&
                    txtPassword.Text == "admin123")
                {
                    frmMunicipality municipality = new frmMunicipality();
                    municipality.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid municipality login.");
                }
            }
        }
    }
}
