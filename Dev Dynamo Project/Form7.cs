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
        string filePath = @"C:\Users\Makro\OneDrive\Desktop\Collected Waste.txt";

            if (!File.Exists(filePath))
            {
                lblWasteInfo.Text = "No collections found yet.";
                return;
            }

            string[] allLines = File.ReadAllLines(filePath);

            string date = "", waste = "", weight = "", status = "", payment = "";

            foreach (string line in allLines)
            {
                if (line.StartsWith("Date Collected"))
                    date = line.Split(':')[1].Trim();
                else if (line.StartsWith("Waste Type"))
                    waste = line.Split(':')[1].Trim();
                else if (line.StartsWith("Weight"))
                    weight = line.Split(':')[1].Trim();
                else if (line.StartsWith("Status"))
                    status = line.Split(':')[1].Trim();
                else if (line.StartsWith("Payment"))
                    payment = line.Split(':')[1].Trim();
            }

            if (waste != "")
            {
                lblWasteInfo.Text = $"You collected {waste} waste";
                lblDateInfo.Text = $"On {date}";
                lblWeightInfo.Text = $"Weighing {weight}";
                lblCollectionStatus.Text = $"Collection Status: {status}";
                lblPaymentStatus.Text = $"Payment Status: {payment}";

                if (status.Contains("Pending"))
                    lblCollectionStatus.ForeColor = Color.Orange;
                else
                    lblCollectionStatus.ForeColor = Color.Green;
            }
            else
            {
                lblWasteInfo.Text = "No collections found yet.";
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
