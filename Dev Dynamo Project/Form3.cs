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
            if (!radMunicipality.Checked && !radSMME.Checked)
            {
                MessageBox.Show("please select role");
                return;
            }

            if (radMunicipality.Checked)
            {
                if (txtUsername.Text == "Municipality" && txtPassword.Text == "admin123")
                {
                    MessageBox.Show("Municipality Login Successful");
                    frmMunicipality municipality = new frmMunicipality();
                    municipality.Show();
                    this.Hide();
                }
                return;
            }

            if (radSMME.Checked)
             
            {
                

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Applicants Details.txt");
                string[] lines = File.ReadAllLines(filePath);

                string savedUsername = "";
                string savedPassword = "";

                foreach (string line in lines)
                {
                    if (line.StartsWith("Username"))
                    {
                        savedUsername = line.Replace("Username", "").Trim();
                    }

                    if (line.StartsWith("Password"))
                    {
                        savedPassword = line.Replace("Password", "").Trim();

                        if (txtUsername.Text == savedUsername &&
                            txtPassword.Text == savedPassword)
                        {
                            MessageBox.Show("Login Successful");
                            break;
                        }

                       
                    }
                }

                if (txtUsername.Text != savedUsername || txtPassword.Text != savedPassword)
                {
                    MessageBox.Show("Invalid Username or Password");
                    return;
                }

                // 2. If password correct, check which role they selected

                frmSMME SMME = new frmSMME();
                SMME.Show();
                this.Hide();
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
           

              
        }
            

            
           
        

        private void radSMME_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
