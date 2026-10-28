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
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.dtpCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitCollection = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWasteType
            // 
            this.lblWasteType.AutoSize = true;
            this.lblWasteType.Location = new System.Drawing.Point(291, 164);
            this.lblWasteType.Name = "lblWasteType";
            this.lblWasteType.Size = new System.Drawing.Size(136, 25);
            this.lblWasteType.TabIndex = 0;
            this.lblWasteType.Text = "Waste Type:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(291, 221);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(119, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight(kg)";
            // 
            // lblCollectionDate
            // 
            this.lblCollectionDate.AutoSize = true;
            this.lblCollectionDate.Location = new System.Drawing.Point(291, 283);
            this.lblCollectionDate.Name = "lblCollectionDate";
            this.lblCollectionDate.Size = new System.Drawing.Size(166, 25);
            this.lblCollectionDate.TabIndex = 2;
            this.lblCollectionDate.Text = "Collection Date:";
            // 
            // lblProof
            // 
            this.lblProof.AutoSize = true;
            this.lblProof.Location = new System.Drawing.Point(285, 352);
            this.lblProof.Name = "lblProof";
            this.lblProof.Size = new System.Drawing.Size(172, 25);
            this.lblProof.TabIndex = 3;
            this.lblProof.Text = "Collection Proof:";
            // 
            // picProof
            // 
            this.picProof.Location = new System.Drawing.Point(558, 338);
            this.picProof.Name = "picProof";
            this.picProof.Size = new System.Drawing.Size(528, 239);
            this.picProof.TabIndex = 4;
            this.picProof.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(721, 530);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(151, 36);
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
            "Plastic",
            "Glass",
            "Cans"});
            this.cmbWasteType.Location = new System.Drawing.Point(614, 156);
            this.cmbWasteType.Name = "cmbWasteType";
            this.cmbWasteType.Size = new System.Drawing.Size(348, 33);
            this.cmbWasteType.TabIndex = 6;
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(614, 219);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(348, 30);
            this.nudWeight.TabIndex = 7;
            // 
            // dtpCollectionDate
            // 
            this.dtpCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCollectionDate.Location = new System.Drawing.Point(614, 283);
            this.dtpCollectionDate.Name = "dtpCollectionDate";
            this.dtpCollectionDate.Size = new System.Drawing.Size(348, 30);
            this.dtpCollectionDate.TabIndex = 8;
            // 
            // btnSubmitCollection
            // 
            this.btnSubmitCollection.Location = new System.Drawing.Point(1255, 603);
            this.btnSubmitCollection.Name = "btnSubmitCollection";
            this.btnSubmitCollection.Size = new System.Drawing.Size(206, 69);
            this.btnSubmitCollection.TabIndex = 9;
            this.btnSubmitCollection.Text = "Submit Collection";
            this.btnSubmitCollection.UseVisualStyleBackColor = true;
            this.btnSubmitCollection.Click += new System.EventHandler(this.btnSubmitCollection_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(200, 583);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(214, 68);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(450, 583);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 68);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMy
            // 
            this.btnMy.Location = new System.Drawing.Point(1024, 594);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(193, 68);
            this.btnMy.TabIndex = 13;
            this.btnMy.Text = "My Dashboard";
            this.btnMy.UseVisualStyleBackColor = true;
            this.btnMy.Click += new System.EventHandler(this.btnMy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(306, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Please consider your application unsuccessful if no feedback is recieved within 3" +
    "- 5 days";
            // 
            // frmSMME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1596, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMy);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmitCollection);
            this.Controls.Add(this.dtpCollectionDate);
            this.Controls.Add(this.nudWeight);
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
            this.Load += new System.EventHandler(this.frmSMME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.DateTimePicker dtpCollectionDate;
        private System.Windows.Forms.Button btnSubmitCollection;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMy;
        private System.Windows.Forms.Label label1;
    }
}