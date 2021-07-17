
namespace CinemaReservationManager.Application
{
    partial class WelcomeForm
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
            this.btnLoginAsUser = new System.Windows.Forms.Button();
            this.btnLoginAsAdmin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginAsUser
            // 
            this.btnLoginAsUser.Location = new System.Drawing.Point(65, 120);
            this.btnLoginAsUser.Name = "btnLoginAsUser";
            this.btnLoginAsUser.Size = new System.Drawing.Size(194, 44);
            this.btnLoginAsUser.TabIndex = 0;
            this.btnLoginAsUser.Text = "Login As User";
            this.btnLoginAsUser.UseVisualStyleBackColor = true;
            this.btnLoginAsUser.Click += new System.EventHandler(this.btnLoginAsUser_Click);
            // 
            // btnLoginAsAdmin
            // 
            this.btnLoginAsAdmin.Location = new System.Drawing.Point(65, 205);
            this.btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            this.btnLoginAsAdmin.Size = new System.Drawing.Size(194, 44);
            this.btnLoginAsAdmin.TabIndex = 1;
            this.btnLoginAsAdmin.Text = "Login As Admin";
            this.btnLoginAsAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAsAdmin.Click += new System.EventHandler(this.btnLoginAsAdmin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(65, 426);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(194, 44);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "lblwelcome";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLoginAsAdmin);
            this.Controls.Add(this.btnLoginAsUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginAsUser;
        private System.Windows.Forms.Button btnLoginAsAdmin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
    }
}