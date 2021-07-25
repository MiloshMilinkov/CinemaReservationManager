
namespace CinemaReservationManager.Application.Forms.Administration
{
    partial class AdministrationContainerForm
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
            this.pnlLoggedAdmin = new System.Windows.Forms.Panel();
            this.lblLoggedAdmin = new System.Windows.Forms.Label();
            this.pnlLoggedAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoggedAdmin
            // 
            this.pnlLoggedAdmin.Controls.Add(this.lblLoggedAdmin);
            this.pnlLoggedAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoggedAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlLoggedAdmin.Name = "pnlLoggedAdmin";
            this.pnlLoggedAdmin.Size = new System.Drawing.Size(376, 47);
            this.pnlLoggedAdmin.TabIndex = 1;
            // 
            // lblLoggedAdmin
            // 
            this.lblLoggedAdmin.AutoSize = true;
            this.lblLoggedAdmin.Location = new System.Drawing.Point(3, 9);
            this.lblLoggedAdmin.Name = "lblLoggedAdmin";
            this.lblLoggedAdmin.Size = new System.Drawing.Size(60, 13);
            this.lblLoggedAdmin.TabIndex = 0;
            this.lblLoggedAdmin.Text = "Logged as:";
            // 
            // AdministrationContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 505);
            this.Controls.Add(this.pnlLoggedAdmin);
            this.IsMdiContainer = true;
            this.Name = "AdministrationContainerForm";
            this.Text = "AdministrationForm";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.pnlLoggedAdmin.ResumeLayout(false);
            this.pnlLoggedAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoggedAdmin;
        private System.Windows.Forms.Label lblLoggedAdmin;
    }
}