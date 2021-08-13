
namespace CinemaReservationManager.Application.Forms.Administration
{
    partial class MoviesForm
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
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.Location = new System.Drawing.Point(41, 44);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(284, 186);
            this.lstMovies.TabIndex = 0;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(41, 250);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(126, 63);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(199, 250);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 63);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 442);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lstMovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBack;
    }
}