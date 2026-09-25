namespace Dev_Dynamo_Project
{
    partial class frmSMME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSMME));
            this.lblWasteType = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCollectionDate = new System.Windows.Forms.Label();
            this.lblProof = new System.Windows.Forms.Label();
            this.picProof = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.cmbWasteType = new System.Windows.Forms.ComboBox();
            this.nubWeight = new System.Windows.Forms.NumericUpDown();
            this.dtpCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitCollection = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWasteType
            // 
            this.lblWasteType.AutoSize = true;
            this.lblWasteType.Location = new System.Drawing.Point(116, 186);
            this.lblWasteType.Name = "lblWasteType";
            this.lblWasteType.Size = new System.Drawing.Size(136, 25);
            this.lblWasteType.TabIndex = 0;
            this.lblWasteType.Text = "Waste Type:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(121, 257);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(119, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight(kg)";
            // 
            // lblCollectionDate
            // 
            this.lblCollectionDate.AutoSize = true;
            this.lblCollectionDate.Location = new System.Drawing.Point(121, 336);
            this.lblCollectionDate.Name = "lblCollectionDate";
            this.lblCollectionDate.Size = new System.Drawing.Size(166, 25);
            this.lblCollectionDate.TabIndex = 2;
            this.lblCollectionDate.Text = "Collection Date:";
            // 
            // lblProof
            // 
            this.lblProof.AutoSize = true;
            this.lblProof.Location = new System.Drawing.Point(121, 488);
            this.lblProof.Name = "lblProof";
            this.lblProof.Size = new System.Drawing.Size(172, 25);
            this.lblProof.TabIndex = 3;
            this.lblProof.Text = "Collection Proof:";
            // 
            // picProof
            // 
            this.picProof.Location = new System.Drawing.Point(326, 415);
            this.picProof.Name = "picProof";
            this.picProof.Size = new System.Drawing.Size(254, 140);
            this.picProof.TabIndex = 4;
            this.picProof.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(358, 452);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(149, 61);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload Proof";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cmbWasteType
            // 
            this.cmbWasteType.FormattingEnabled = true;
            this.cmbWasteType.Items.AddRange(new object[] {
            "Paper",
            "Platic",
            "Glass",
            "Cans"});
            this.cmbWasteType.Location = new System.Drawing.Point(326, 186);
            this.cmbWasteType.Name = "cmbWasteType";
            this.cmbWasteType.Size = new System.Drawing.Size(348, 33);
            this.cmbWasteType.TabIndex = 6;
            // 
            // nubWeight
            // 
            this.nubWeight.Location = new System.Drawing.Point(326, 252);
            this.nubWeight.Name = "nubWeight";
            this.nubWeight.Size = new System.Drawing.Size(348, 30);
            this.nubWeight.TabIndex = 7;
            // 
            // dtpCollectionDate
            // 
            this.dtpCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCollectionDate.Location = new System.Drawing.Point(326, 338);
            this.dtpCollectionDate.Name = "dtpCollectionDate";
            this.dtpCollectionDate.Size = new System.Drawing.Size(348, 30);
            this.dtpCollectionDate.TabIndex = 8;
            // 
            // btnSubmitCollection
            // 
            this.btnSubmitCollection.Location = new System.Drawing.Point(1082, 604);
            this.btnSubmitCollection.Name = "btnSubmitCollection";
            this.btnSubmitCollection.Size = new System.Drawing.Size(206, 69);
            this.btnSubmitCollection.TabIndex = 9;
            this.btnSubmitCollection.Text = "Submit Collection";
            this.btnSubmitCollection.UseVisualStyleBackColor = true;
            this.btnSubmitCollection.Click += new System.EventHandler(this.btnSubmitCollection_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(126, 623);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 68);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSMME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmitCollection);
            this.Controls.Add(this.dtpCollectionDate);
            this.Controls.Add(this.nubWeight);
            this.Controls.Add(this.cmbWasteType);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picProof);
            this.Controls.Add(this.lblProof);
            this.Controls.Add(this.lblCollectionDate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblWasteType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSMME";
            this.Text = "SMME";
            ((System.ComponentModel.ISupportInitialize)(this.picProof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWasteType;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCollectionDate;
        private System.Windows.Forms.Label lblProof;
        private System.Windows.Forms.PictureBox picProof;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox cmbWasteType;
        private System.Windows.Forms.NumericUpDown nubWeight;
        private System.Windows.Forms.DateTimePicker dtpCollectionDate;
        private System.Windows.Forms.Button btnSubmitCollection;
        private System.Windows.Forms.Button btnBack;
    }
}