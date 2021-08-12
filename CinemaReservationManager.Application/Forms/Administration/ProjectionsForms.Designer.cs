
namespace CinemaReservationManager.Application.Forms
{
    partial class ProjectionsForms
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAddProjection = new System.Windows.Forms.Button();
            this.lstProjections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(198, 234);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 63);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAddProjection
            // 
            this.btnAddProjection.Location = new System.Drawing.Point(40, 234);
            this.btnAddProjection.Name = "btnAddProjection";
            this.btnAddProjection.Size = new System.Drawing.Size(126, 63);
            this.btnAddProjection.TabIndex = 9;
            this.btnAddProjection.Text = "Add Projection";
            this.btnAddProjection.UseVisualStyleBackColor = true;
            this.btnAddProjection.Click += new System.EventHandler(this.btnAddProjection_Click);
            // 
            // lstProjections
            // 
            this.lstProjections.FormattingEnabled = true;
            this.lstProjections.Location = new System.Drawing.Point(40, 28);
            this.lstProjections.Name = "lstProjections";
            this.lstProjections.Size = new System.Drawing.Size(284, 186);
            this.lstProjections.TabIndex = 8;
            // 
            // ProjectionsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 442);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAddProjection);
            this.Controls.Add(this.lstProjections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectionsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Projections";
            this.Load += new System.EventHandler(this.ProjectionsForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAddProjection;
        private System.Windows.Forms.ListBox lstProjections;
    }
}