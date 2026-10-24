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
    public partial class frmsmmedashboard : Form
    {
        public frmsmmedashboard()
        {
            InitializeComponent();
        }

        private void frmsmmedashboard_Load(object sender, EventArgs e)
        {
        string filePath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
        "Collections.txt");

            if (!File.Exists(filePath))
            {
                lblWasteInfo.Text = "No collections found yet.";
                return;
            }

            // Get the last line that has data (the last submission)
            string lastRecord = File.ReadAllLines(filePath)
                                    .Where(line => line.Contains("|"))
                                    .LastOrDefault();

            if (lastRecord != null)
            {
                string[] p = lastRecord.Split('|');
                // p[0]=ID, p[1]=WasteType, p[2]=Weight, p[3]=Date, p[4]=Proof, p[5]=CollectionStatus, p[6]=PaymentStatus

                lblWasteInfo.Text = $"You collected {p[1]} waste";
                lblDateInfo.Text = $"On {p[3]}";
                lblWeightInfo.Text = $"Weighing {p[2]} KG";
                lblCollectionStatus.Text = $"Collection Status: {p[5]}"; // Pending
                lblPaymentStatus.Text = $"Payment Status: {p[6]}"; // In Progress / Unpaid

                // Make Pending orange, Approved green
                if (p[5] == "Pending")
                    lblCollectionStatus.ForeColor = Color.Orange;
                else
                    lblCollectionStatus.ForeColor = Color.Green;
            } 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmRecycling recycling = new frmRecycling();
            recycling.Show();
            this.Hide();
        }

        private void btnProcced_Click(object sender, EventArgs e)
        {
            frmpay pay = new frmpay();
            pay.Show();
            this.Hide();
        }
    }
}
