namespace Dev_Dynamo_Project
{
    partial class frmpay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpay));
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblBranchCode = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.btnSaveBankDetails = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Location = new System.Drawing.Point(435, 224);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(229, 25);
            this.lblAccountHolder.TabIndex = 2;
            this.lblAccountHolder.Text = "Account Holder Name:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(447, 293);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(179, 25);
            this.lblAccountNumber.TabIndex = 3;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(447, 377);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(153, 25);
            this.lblAccountType.TabIndex = 4;
            this.lblAccountType.Text = "Account Type:";
            // 
            // lblBranchCode
            // 
            this.lblBranchCode.AutoSize = true;
            this.lblBranchCode.Location = new System.Drawing.Point(447, 461);
            this.lblBranchCode.Name = "lblBranchCode";
            this.lblBranchCode.Size = new System.Drawing.Size(145, 25);
            this.lblBranchCode.TabIndex = 5;
            this.lblBranchCode.Text = "Branch Code:";
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(949, 149);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(121, 33);
            this.cmbBank.TabIndex = 8;
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(949, 224);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(100, 30);
            this.txtAccountHolder.TabIndex = 9;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(959, 288);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 30);
            this.txtAccountNumber.TabIndex = 10;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(949, 357);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(121, 33);
            this.cmbAccountType.TabIndex = 11;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(959, 436);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(100, 30);
            this.txtBranchCode.TabIndex = 12;
            // 
            // btnSaveBankDetails
            // 
            this.btnSaveBankDetails.Location = new System.Drawing.Point(271, 538);
            this.btnSaveBankDetails.Name = "btnSaveBankDetails";
            this.btnSaveBankDetails.Size = new System.Drawing.Size(237, 63);
            this.btnSaveBankDetails.TabIndex = 13;
            this.btnSaveBankDetails.Text = "Save Bank Details";
            this.btnSaveBankDetails.UseVisualStyleBackColor = true;
            this.btnSaveBankDetails.Click += new System.EventHandler(this.btnSaveBankDetails_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(366, 38);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(168, 25);
            this.lblTittle.TabIndex = 14;
            this.lblTittle.Text = "Payment Details";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(435, 157);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(135, 25);
            this.lblBank.TabIndex = 15;
            this.lblBank.Text = "Select Bank:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(678, 557);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(171, 25);
            this.lblPaymentStatus.TabIndex = 16;
            this.lblPaymentStatus.Text = "Payment Status:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1100, 557);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(134, 63);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmpay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1425, 703);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnSaveBankDetails);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtAccountHolder);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.lblBranchCode);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAccountHolder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmpay";
            this.Text = "Payment Details";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblBranchCode;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.Button btnSaveBankDetails;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Button btnLogOut;
    }
}