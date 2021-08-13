
namespace CinemaReservationManager.Application.Forms.MainManagement
{
    partial class MainManagementMainForm
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
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.Location = new System.Drawing.Point(13, 26);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(612, 134);
            this.lstReservations.TabIndex = 0;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(12, 166);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(613, 23);
            this.btnAddReservation.TabIndex = 1;
            this.btnAddReservation.Text = "Add ";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // MainManagementMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 209);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lstReservations);
            this.Name = "MainManagementMainForm";
            this.Text = "MainManagementMainForm";
            this.Load += new System.EventHandler(this.MainManagementMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Button btnAddReservation;
    }
}