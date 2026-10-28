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

using System.Net;
using System.Net.Mail;


namespace Dev_Dynamo_Project
{
    public partial class frmMunicipality : Form
    {
        public frmMunicipality()
        {
            InitializeComponent();

        }

        private void btnApplicationDetails_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Makro\OneDrive\Desktop\Applicants Details.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Applications.txt was not found.");
                return;
            }

            lstOutput.Items.Clear();

            using (StreamReader myNN = new StreamReader(filePath))
            {
                string line;

                while ((line = myNN.ReadLine()) != null)
                {
                    lstOutput.Items.Add(line);
                }
            }
        }

        private void btnCollectionDetails_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Makro\OneDrive\Desktop\Collected Waste.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Collection was not found.");
                return;
            }

            lstOutput.Items.Clear();

            using (StreamReader myNN = new StreamReader(filePath))
            {
                string line;

                while ((line = myNN.ReadLine()) != null)
                {
                    ;
                    lstOutput.Items.Add(line);
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lstOutput.SelectedItem == null)
            {
                MessageBox.Show("Please select a collection first.");
                return;
            }

            string record = lstOutput.SelectedItem.ToString();

            string[] lines = record.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            double weight = -1;

            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("Weight"))
                {
                    string weightText = line.Split(':')[1]
                                             .Replace("KG", "")
                                             .Trim();

                    if (!double.TryParse(weightText, out weight))
                    {
                        MessageBox.Show("Invalid collection weight.");
                        return;
                    }

                    break;
                }
            }

            if (weight == -1)
            {
                MessageBox.Show("Could not find the collection weight.");
                return;
            }

            if (weight >= 50)
            {
                MessageBox.Show("Collection approved!");
            }
            else
            {
                MessageBox.Show("Collection rejected because it is below 50 KG.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if(lstOutput.SelectedItem == null)
    {
                MessageBox.Show("Please select a collection first.");
                return;
            }

            string record = lstOutput.SelectedItem.ToString();

            string[] lines = record.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            double weight = -1;

            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("Weight"))
                {
                    string weightText = line.Split(':')[1]
                                             .Replace("KG", "")
                                             .Trim();

                    if (!double.TryParse(weightText, out weight))
                    {
                        MessageBox.Show("Invalid collection weight.");
                        return;
                    }

                    break;
                }
            }

            if (weight == -1)
            {
                MessageBox.Show("Could not find the collection weight.");
                return;
            }

            if (weight < 50)
            {
                MessageBox.Show("Collection rejected because it is below 50 KG.");
            }
            else
            {
                MessageBox.Show(
                    "This collection has 50 KG or more. Please use the Approve button.");
            }
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmApproval approval = new frmApproval();
            approval.Show();
            this.Hide();
        }


        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmApproval approve = new frmApproval();
            approve.Show();
            this.Hide();
        }

        private void frmMunicipality_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmRecycling recycle = new frmRecycling();
            recycle .Show();
            this.Show();
        }
    }
    
    
}

