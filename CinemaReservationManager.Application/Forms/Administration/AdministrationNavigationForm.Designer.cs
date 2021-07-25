
namespace CinemaReservationManager.Application.Forms.Administration
{
    partial class AdministrationNavigationForm
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
            this.btnStandardUserAdministration = new System.Windows.Forms.Button();
            this.btnMovieAdministration = new System.Windows.Forms.Button();
            this.btnHallAdministration = new System.Windows.Forms.Button();
            this.btnProjectionAdministration = new System.Windows.Forms.Button();
            this.btnReservationAdministration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStandardUserAdministration
            // 
            this.btnStandardUserAdministration.Location = new System.Drawing.Point(57, 40);
            this.btnStandardUserAdministration.Name = "btnStandardUserAdministration";
            this.btnStandardUserAdministration.Size = new System.Drawing.Size(226, 39);
            this.btnStandardUserAdministration.TabIndex = 0;
            this.btnStandardUserAdministration.Text = "Manage Standard users";
            this.btnStandardUserAdministration.UseVisualStyleBackColor = true;
            this.btnStandardUserAdministration.Click += new System.EventHandler(this.btnStandardUserAdministration_Click);
            // 
            // btnMovieAdministration
            // 
            this.btnMovieAdministration.Location = new System.Drawing.Point(57, 118);
            this.btnMovieAdministration.Name = "btnMovieAdministration";
            this.btnMovieAdministration.Size = new System.Drawing.Size(226, 39);
            this.btnMovieAdministration.TabIndex = 1;
            this.btnMovieAdministration.Text = "Manage Movies";
            this.btnMovieAdministration.UseVisualStyleBackColor = true;
            // 
            // btnHallAdministration
            // 
            this.btnHallAdministration.Location = new System.Drawing.Point(57, 202);
            this.btnHallAdministration.Name = "btnHallAdministration";
            this.btnHallAdministration.Size = new System.Drawing.Size(226, 39);
            this.btnHallAdministration.TabIndex = 2;
            this.btnHallAdministration.Text = "Manage Halls";
            this.btnHallAdministration.UseVisualStyleBackColor = true;
            // 
            // btnProjectionAdministration
            // 
            this.btnProjectionAdministration.Location = new System.Drawing.Point(57, 288);
            this.btnProjectionAdministration.Name = "btnProjectionAdministration";
            this.btnProjectionAdministration.Size = new System.Drawing.Size(226, 39);
            this.btnProjectionAdministration.TabIndex = 3;
            this.btnProjectionAdministration.Text = "Manage Projections";
            this.btnProjectionAdministration.UseVisualStyleBackColor = true;
            // 
            // btnReservationAdministration
            // 
            this.btnReservationAdministration.Location = new System.Drawing.Point(57, 373);
            this.btnReservationAdministration.Name = "btnReservationAdministration";
            this.btnReservationAdministration.Size = new System.Drawing.Size(226, 39);
            this.btnReservationAdministration.TabIndex = 4;
            this.btnReservationAdministration.Text = "Manage Reservations";
            this.btnReservationAdministration.UseVisualStyleBackColor = true;
            // 
            // AdministrationNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 454);
            this.Controls.Add(this.btnReservationAdministration);
            this.Controls.Add(this.btnProjectionAdministration);
            this.Controls.Add(this.btnHallAdministration);
            this.Controls.Add(this.btnMovieAdministration);
            this.Controls.Add(this.btnStandardUserAdministration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrationNavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdministrationNavigationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStandardUserAdministration;
        private System.Windows.Forms.Button btnMovieAdministration;
        private System.Windows.Forms.Button btnHallAdministration;
        private System.Windows.Forms.Button btnProjectionAdministration;
        private System.Windows.Forms.Button btnReservationAdministration;
    }
}