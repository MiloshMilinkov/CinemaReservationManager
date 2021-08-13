
namespace CinemaReservationManager.Application.Forms.Administration
{
    partial class ReservationAdministrationForm
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
            this.cmbProjection = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.txtOverallPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProjection
            // 
            this.cmbProjection.FormattingEnabled = true;
            this.cmbProjection.Location = new System.Drawing.Point(121, 32);
            this.cmbProjection.Name = "cmbProjection";
            this.cmbProjection.Size = new System.Drawing.Size(121, 21);
            this.cmbProjection.TabIndex = 0;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(121, 81);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 1;
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Location = new System.Drawing.Point(121, 135);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfSeats.TabIndex = 2;
            // 
            // txtOverallPrice
            // 
            this.txtOverallPrice.Location = new System.Drawing.Point(121, 183);
            this.txtOverallPrice.Name = "txtOverallPrice";
            this.txtOverallPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOverallPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of seats:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Overall price:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReservationAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 403);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOverallPrice);
            this.Controls.Add(this.txtNumberOfSeats);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.cmbProjection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationAdministrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReservationAdministration";
            this.Load += new System.EventHandler(this.ReservationAdministrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProjection;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.TextBox txtOverallPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}