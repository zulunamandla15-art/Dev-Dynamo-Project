namespace Dev_Dynamo_Project
{
    partial class frmsmmedashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsmmedashboard));
            this.lblWasteInfo = new System.Windows.Forms.Label();
            this.lblDateInfo = new System.Windows.Forms.Label();
            this.lblWeightInfo = new System.Windows.Forms.Label();
            this.lblCollectionStatus = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDateCollected = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCollection = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWasteInfo
            // 
            this.lblWasteInfo.AutoSize = true;
            this.lblWasteInfo.Location = new System.Drawing.Point(583, 289);
            this.lblWasteInfo.Name = "lblWasteInfo";
            this.lblWasteInfo.Size = new System.Drawing.Size(187, 25);
            this.lblWasteInfo.TabIndex = 0;
            this.lblWasteInfo.Text = "Waste Information";
            // 
            // lblDateInfo
            // 
            this.lblDateInfo.AutoSize = true;
            this.lblDateInfo.Location = new System.Drawing.Point(583, 372);
            this.lblDateInfo.Name = "lblDateInfo";
            this.lblDateInfo.Size = new System.Drawing.Size(57, 25);
            this.lblDateInfo.TabIndex = 1;
            this.lblDateInfo.Text = "Date";
            // 
            // lblWeightInfo
            // 
            this.lblWeightInfo.AutoSize = true;
            this.lblWeightInfo.Location = new System.Drawing.Point(583, 454);
            this.lblWeightInfo.Name = "lblWeightInfo";
            this.lblWeightInfo.Size = new System.Drawing.Size(80, 25);
            this.lblWeightInfo.TabIndex = 2;
            this.lblWeightInfo.Text = "Weight";
            // 
            // lblCollectionStatus
            // 
            this.lblCollectionStatus.AutoSize = true;
            this.lblCollectionStatus.Location = new System.Drawing.Point(583, 530);
            this.lblCollectionStatus.Name = "lblCollectionStatus";
            this.lblCollectionStatus.Size = new System.Drawing.Size(221, 25);
            this.lblCollectionStatus.TabIndex = 3;
            this.lblCollectionStatus.Text = "Collection Information";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(583, 627);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(105, 25);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "payments";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(238, 289);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(136, 25);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Waste Type:";
            // 
            // lblDateCollected
            // 
            this.lblDateCollected.AutoSize = true;
            this.lblDateCollected.Location = new System.Drawing.Point(238, 372);
            this.lblDateCollected.Name = "lblDateCollected";
            this.lblDateCollected.Size = new System.Drawing.Size(161, 25);
            this.lblDateCollected.TabIndex = 6;
            this.lblDateCollected.Text = "Date Collected:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(238, 454);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(189, 25);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "Weight Measured:";
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(238, 530);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(183, 25);
            this.lblCollection.TabIndex = 8;
            this.lblCollection.Text = "Collection Status:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(238, 627);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(171, 25);
            this.lblPayment.TabIndex = 9;
            this.lblPayment.Text = "Payment Status:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1401, 726);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 56);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmsmmedashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1553, 794);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblCollection);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblDateCollected);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblCollectionStatus);
            this.Controls.Add(this.lblWeightInfo);
            this.Controls.Add(this.lblDateInfo);
            this.Controls.Add(this.lblWasteInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmsmmedashboard";
            this.Text = "SMME DASHBOARD";
            this.Load += new System.EventHandler(this.frmsmmedashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWasteInfo;
        private System.Windows.Forms.Label lblDateInfo;
        private System.Windows.Forms.Label lblWeightInfo;
        private System.Windows.Forms.Label lblCollectionStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDateCollected;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnLogout;
    }
}