
namespace CinemaReservationManager.Application.Forms.Administration
{
    partial class MovieAdministrationForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGanre = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtMovieLenght = new System.Windows.Forms.NumericUpDown();
            this.txtAgeRestriction = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovieLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeRestriction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 46);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGanre
            // 
            this.txtGanre.Location = new System.Drawing.Point(89, 123);
            this.txtGanre.Name = "txtGanre";
            this.txtGanre.Size = new System.Drawing.Size(145, 20);
            this.txtGanre.TabIndex = 13;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(88, 74);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(144, 20);
            this.txtMovieName.TabIndex = 12;
            // 
            // txtMovieLenght
            // 
            this.txtMovieLenght.Location = new System.Drawing.Point(89, 164);
            this.txtMovieLenght.Name = "txtMovieLenght";
            this.txtMovieLenght.Size = new System.Drawing.Size(144, 20);
            this.txtMovieLenght.TabIndex = 23;
            // 
            // txtAgeRestriction
            // 
            this.txtAgeRestriction.Location = new System.Drawing.Point(88, 201);
            this.txtAgeRestriction.Name = "txtAgeRestriction";
            this.txtAgeRestriction.Size = new System.Drawing.Size(145, 20);
            this.txtAgeRestriction.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MovieAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 415);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAgeRestriction);
            this.Controls.Add(this.txtMovieLenght);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGanre);
            this.Controls.Add(this.txtMovieName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieAdministrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MovieAdministrationForm";
            this.Load += new System.EventHandler(this.MovieAdministrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMovieLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeRestriction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGanre;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.NumericUpDown txtMovieLenght;
        private System.Windows.Forms.NumericUpDown txtAgeRestriction;
        private System.Windows.Forms.Button btnBack;
    }
}