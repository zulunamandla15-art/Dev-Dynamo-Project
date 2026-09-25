namespace Dev_Dynamo_Project
{
    partial class frmMunicipality
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCollections = new System.Windows.Forms.DataGridView();
            this.picProofView = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProofView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCollections
            // 
            this.dgvCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollections.Location = new System.Drawing.Point(23, 67);
            this.dgvCollections.Name = "dgvCollections";
            this.dgvCollections.RowHeadersWidth = 51;
            this.dgvCollections.RowTemplate.Height = 24;
            this.dgvCollections.Size = new System.Drawing.Size(1220, 238);
            this.dgvCollections.TabIndex = 0;
            this.dgvCollections.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCollections_CellClick_2);
            // 
            // picProofView
            // 
            this.picProofView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProofView.Location = new System.Drawing.Point(645, 411);
            this.picProofView.Name = "picProofView";
            this.picProofView.Size = new System.Drawing.Size(598, 256);
            this.picProofView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProofView.TabIndex = 1;
            this.picProofView.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(135, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMunicipality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.dgvCollections);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picProofView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMunicipality";
            this.Text = "Municipality";
            this.Load += new System.EventHandler(this.frmMunicipality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProofView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCollections;
        private System.Windows.Forms.PictureBox picProofView;
        private System.Windows.Forms.Button btnBack;
    }
}