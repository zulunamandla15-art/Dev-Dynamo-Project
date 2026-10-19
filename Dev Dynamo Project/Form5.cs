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
    public partial class frmSMME : Form
    {
        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SMMECollections.txt");
        string selectedImagePath = " ";
        public frmSMME()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|.jpg;.jpeg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = open.FileName;
                picProof.ImageLocation = selectedImagePath; // show it on SMME form
            }
        }

        private void btnSubmitCollection_Click(object sender, EventArgs e)
        {

            if (cmbWasteType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the waste type.");
                cmbWasteType.Focus();
                return;
            }
            if (nudWeight.Value <= 0)
            {
                MessageBox.Show("Please enter the weight.");
                nudWeight.Focus();
                return;
            }
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please upload collection proof.");
                return;
            }

            // 1. DECLARE FIRST
            string submissionID = Guid.NewGuid().ToString();
            string wasteType = cmbWasteType.Text.Trim();
            double weight = (double)nudWeight.Value;
            string collectionDate = dtpCollectionDate.Value.ToString("yyyy/MM/dd");
            string proofFilePath = selectedImagePath;
            string collectionStatus = "Pending";
            string paymentStatus = "Unpaid";

            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("----- SMME Collection Record -----");
                writer.WriteLine($"Date Collected : {collectionDate}");
                writer.WriteLine($"Waste Type     : {wasteType}");
                writer.WriteLine($"Weight         : {weight} KG");
                writer.WriteLine($"Proof File     : {Path.GetFileName(proofFilePath)}");
                writer.WriteLine($"Collection ID  : {submissionID}");
                writer.WriteLine($"Status         : {collectionStatus} - Waiting for approval");
                writer.WriteLine($"Payment        : {paymentStatus}-Pending");
                writer.WriteLine("----------------------------------");
                writer.WriteLine("");
            }

            // 3. THEN SHOW + CLEAR
            MessageBox.Show("Collection submitted successfully!\nYour collection status is Pending.");

            cmbWasteType.SelectedIndex = -1;
            nudWeight.Value = 1;
            dtpCollectionDate.Value = DateTime.Today;
            lblProofPath.Text = "No proof selected";
            selectedImagePath = "";



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmResetPassword ResetPassword = new frmResetPassword();
            ResetPassword.Show();
            this.Hide();
        }

        private void frmSMME_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmRecycling home = new frmRecycling();
            home.Show();
            this.Hide();
        }

        private void btnMy_Click(object sender, EventArgs e)
        {
            frmsmmedashboard dashboard=new frmsmmedashboard();
            dashboard.Show();
            this.Hide();

        }
    }
}
