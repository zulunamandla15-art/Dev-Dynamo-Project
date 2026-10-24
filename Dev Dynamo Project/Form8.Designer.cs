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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMunicipality));
            this.btnApplicationDetails = new System.Windows.Forms.Button();
            this.btnCollectionDetails = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApplicationDetails
            // 
            this.btnApplicationDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnApplicationDetails.Location = new System.Drawing.Point(121, 21);
            this.btnApplicationDetails.Name = "btnApplicationDetails";
            this.btnApplicationDetails.Size = new System.Drawing.Size(214, 76);
            this.btnApplicationDetails.TabIndex = 1;
            this.btnApplicationDetails.Text = " Application details";
            this.btnApplicationDetails.UseVisualStyleBackColor = false;
            this.btnApplicationDetails.Click += new System.EventHandler(this.btnApplicationDetails_Click);
            // 
            // btnCollectionDetails
            // 
            this.btnCollectionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCollectionDetails.Location = new System.Drawing.Point(384, 21);
            this.btnCollectionDetails.Name = "btnCollectionDetails";
            this.btnCollectionDetails.Size = new System.Drawing.Size(261, 76);
            this.btnCollectionDetails.TabIndex = 3;
            this.btnCollectionDetails.Text = "Collection Details";
            this.btnCollectionDetails.UseVisualStyleBackColor = false;
            this.btnCollectionDetails.Click += new System.EventHandler(this.btnCollectionDetails_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPayments.Location = new System.Drawing.Point(718, 21);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(243, 76);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(121, 191);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(840, 429);
            this.lstOutput.TabIndex = 5;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnApprove.Location = new System.Drawing.Point(121, 141);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(132, 44);
            this.btnApprove.TabIndex = 6;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReject.Location = new System.Drawing.Point(828, 141);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(133, 44);
            this.btnReject.TabIndex = 7;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEmail.Location = new System.Drawing.Point(1160, 596);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(167, 51);
            this.btnEmail.TabIndex = 8;
            this.btnEmail.Text = "Send Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLog.Location = new System.Drawing.Point(31, 623);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(158, 47);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "Log Out";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmMunicipality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1361, 703);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnCollectionDetails);
            this.Controls.Add(this.btnApplicationDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMunicipality";
            this.Text = " Municipality Dashboard";
            this.Load += new System.EventHandler(this.frmMunicipality_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCollectionDetails;
        private System.Windows.Forms.Button btnApplicationDetails;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnLog;
    }
}