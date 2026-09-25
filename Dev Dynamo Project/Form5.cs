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
    public partial class frmSMME : Form
    {
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
            // 1. DECLARE FIRST
            string wasteType = cmbWasteType.Text.Trim();
            double weight = (double)nubWeight.Value; // <-- FOR NUMERIC UP DOWN
            string date = dtpCollectionDate.Value.ToShortDateString();
            string proofPath = selectedImagePath;

            // 2. Validation
            if (wasteType == "" || weight == 0 || proofPath == "")
            {
                MessageBox.Show("Please fill all collection details and upload proof", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Save to central DataStore
            WasteCollection newCollection = new WasteCollection();
            newCollection.BusinessName = Userstore.Username;
            newCollection.WasteType = wasteType;
            newCollection.WeightKG = weight;
            newCollection.CollectionDate = date;
            newCollection.ProofImagePath = proofPath;

            DataStore.AllCollections.Add(newCollection);

            MessageBox.Show("Collection Submitted! Municipality can now see it.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form
            cmbWasteType.SelectedIndex = -1;
            nubWeight.Value = 0; // <-- FOR NUMERIC UP DOWN, not Clear()
            picProof.Image = null;
            selectedImagePath = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmResetPassword ResetPassword = new frmResetPassword();
            ResetPassword.Show();
            this.Hide();
        }
    }
}
