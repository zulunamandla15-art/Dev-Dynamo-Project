using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MunicipalityApproval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // THIS IS YOUR APPROVE BUTTON - this is what other students have
        private async void btnApprove_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string business = txtBusiness.Text;
            string reference = "MUN-" + DateTime.Now.ToString("yyyyMMdd-HHmm");

            if (string.IsNullOrWhiteSpace(email))
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please enter email";
                return;
            }

            lblStatus.ForeColor = Color.Blue;
            lblStatus.Text = "Sending to " + email + "...";

            await SendConfirmationEmail(name, email, business, reference);
        }

        private async Task SendConfirmationEmail(string name, string email, string business, string reference)
        {
            try
            {
                var fromAddress = new MailAddress("thabilemthethwa244@gmail.com", "Municipality SMME");
                var toAddress = new MailAddress(email); // ANY email you type in GUI

                string subject = "Application Received - " + reference;
                string body = "Dear " + name + ",\n\n" + "Thank you for submitting your application to the EThekwini Municipality - SMME Development Unit.\n\n" +
                    "We hereby confirm receipt of your application for :\n" +
                    "Business Name:" + business + "\n" +
                    "Reference Number:" + reference + "\n" +
                    "Date Received:" + DateTime.Now.ToString("dd MMMM yyyy HH:mm") + "\n\n" +
                   " Your application is currently under review. Our team will assess your submissionand communicate the outcome within 5-7 working days.\n\n" +
                   "Please retain your reference number for all future enquiries.\n\n" +
                   "For assistance, contact: smme.support@durban.gov.za | 031 311 1111\n\n" +
                   "Yours faithfully,\n" +
                   "Municipality SMME Support Team\n" +
                   "EThekwini Municipality\n" +
                   "Durban, KwaZulu-Natal";

                var message = new MailMessage(fromAddress, toAddress);
                message.Subject = subject;
                message.Body = body;

                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("thabilemthethwa244@gmail.com", "mmuunseukheb dpwl");

                await client.SendMailAsync(message);

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "SUCCESS! Popped up on " + email;
                MessageBox.Show("SUCCESS! Email popped up on " + email + "\nCheck your phone now!");
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Error: " + ex.Message;
                MessageBox.Show(ex.Message + "\n\nIf on school WiFi, use phone hotspot");
            }
        }
    }
}