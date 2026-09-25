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
    public partial class frmMunicipality : Form
    {
        public frmMunicipality()
        {
            InitializeComponent();
        }

        private void frmMunicipality_Load(object sender, EventArgs e)
        {
            // Show all collections submitted by SMMEs
            dgvCollections.DataSource = null;
            dgvCollections.DataSource = DataStore.AllCollections;

            // Optional: make columns look nice
            dgvCollections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvCollections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // When municipality clicks a row, show its proof
            if (e.RowIndex >= 0)
            {
                string path = DataStore.AllCollections[e.RowIndex].ProofImagePath;
                if (System.IO.File.Exists(path))
                {
                    picProofView.ImageLocation = path; // SAME proof SMME uploaded
                }
            }
        }

        private void dgvCollections_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string path = DataStore.AllCollections[e.RowIndex].ProofImagePath;
                if (System.IO.File.Exists(path))
                {
                    picProofView.ImageLocation = path; // SAME proof SMME uploaded
                    picProofView.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSMME SMME = new frmSMME();
            SMME.Show();
            this.Hide();
        }

        private void dgvCollections_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string path = DataStore.AllCollections[e.RowIndex].ProofImagePath;
                if (System.IO.File.Exists(path))
                {
                    picProofView.ImageLocation = path; // SAME proof SMME uploaded
                    picProofView.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}
