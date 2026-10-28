using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_Dynamo_Project
{
    public partial class frmApproval : Form
    {
        public frmApproval()
        {
            InitializeComponent();
        }

      
        private async void btnNotification_Click(object sender, EventArgs e)
        {
            string name = "Applicant";
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
                var toAddress = new MailAddress(email);

                string subject = "Application Successful - " + reference;
                string body = "Dear " + name + ",\n\n" +
                "Congratulations! Your application has been successful.\n\n" +
                "We are pleased to confirm that your application to the eThekwini Municipality - SMME Development Unit has been approved.\n\n" +
                "Business Name: " + business + "\n" +
                "Reference Number: " + reference + "\n" +
                "Date Approved: " + DateTime.Now.ToString("dd MMMM yyyy HH:mm") + "\n\n" +
                "You can now proceed to the next step and start using our SMME services.\n\n" +
                "Please keep your reference number for all future enquiries.\n\n" +
                "For assistance, contact: smme.support@durban.gov.za | 031 311 1111\n\n" +
                "Yours faithfully,\n" +
                "Municipality SMME Support Team\n" +
                "eThekwini Municipality\n" +
                "Durban, KwaZulu-Natal";

                var message = new MailMessage(fromAddress, toAddress);
                message.Subject = subject;
                message.Body = body;

                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("thabilemthethwa244@gmail.com", "mmuunseukheb dpwl");

                await client.SendMailAsync(message);

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Email Sent";
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Error: " + ex.Message;
                MessageBox.Show(ex.Message + "\n\nIf on school WiFi, use phone hotspot");
            }
        }

        private void frmApproval_Load(object sender, EventArgs e)
        {

        }
    }
    
}
