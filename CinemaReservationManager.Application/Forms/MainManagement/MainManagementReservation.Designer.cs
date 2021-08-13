
namespace CinemaReservationManager.Application.Forms.MainManagement
{
    partial class MainManagementReservation
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblFilters = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cbHalls = new System.Windows.Forms.ComboBox();
            this.cbMovies = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.lstAvailableProjections = new System.Windows.Forms.ListBox();
            this.lblAvailableProjections = new System.Windows.Forms.Label();
            this.lblNumOfSeats = new System.Windows.Forms.Label();
            this.lblOverallPrice = new System.Windows.Forms.Label();
            this.nudNumOfSeats = new System.Windows.Forms.NumericUpDown();
            this.txtOverallPrice = new System.Windows.Forms.TextBox();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Location = new System.Drawing.Point(313, 28);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(125, 13);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Reservation of projection";
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(13, 57);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(37, 13);
            this.lblFilters.TabIndex = 1;
            this.lblFilters.Text = "Filters:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(13, 74);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(53, 13);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "Date from";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(230, 74);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(42, 13);
            this.lblDateTo.TabIndex = 3;
            this.lblDateTo.Text = "Date to";
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(468, 74);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(25, 13);
            this.lblHall.TabIndex = 4;
            this.lblHall.Text = "Hall";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(631, 74);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(36, 13);
            this.lblMovie.TabIndex = 5;
            this.lblMovie.Text = "Movie";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(16, 91);
            this.dtpDateFrom.MinDate = new System.DateTime(2021, 8, 13, 0, 0, 0, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFrom.TabIndex = 6;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(233, 90);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTo.TabIndex = 7;
            // 
            // cbHalls
            // 
            this.cbHalls.FormattingEnabled = true;
            this.cbHalls.Location = new System.Drawing.Point(471, 90);
            this.cbHalls.Name = "cbHalls";
            this.cbHalls.Size = new System.Drawing.Size(121, 21);
            this.cbHalls.TabIndex = 8;
            // 
            // cbMovies
            // 
            this.cbMovies.FormattingEnabled = true;
            this.cbMovies.Location = new System.Drawing.Point(634, 89);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(121, 21);
            this.cbMovies.TabIndex = 9;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(16, 133);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(772, 42);
            this.btnApplyFilter.TabIndex = 10;
            this.btnApplyFilter.Text = "Apply filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // lstAvailableProjections
            // 
            this.lstAvailableProjections.FormattingEnabled = true;
            this.lstAvailableProjections.Location = new System.Drawing.Point(16, 194);
            this.lstAvailableProjections.Name = "lstAvailableProjections";
            this.lstAvailableProjections.Size = new System.Drawing.Size(772, 186);
            this.lstAvailableProjections.TabIndex = 11;
            this.lstAvailableProjections.SelectedValueChanged += new System.EventHandler(this.lstAvailableProjections_SelectedValueChanged);
            // 
            // lblAvailableProjections
            // 
            this.lblAvailableProjections.AutoSize = true;
            this.lblAvailableProjections.Location = new System.Drawing.Point(16, 178);
            this.lblAvailableProjections.Name = "lblAvailableProjections";
            this.lblAvailableProjections.Size = new System.Drawing.Size(104, 13);
            this.lblAvailableProjections.TabIndex = 12;
            this.lblAvailableProjections.Text = "Available projections";
            // 
            // lblNumOfSeats
            // 
            this.lblNumOfSeats.AutoSize = true;
            this.lblNumOfSeats.Location = new System.Drawing.Point(16, 390);
            this.lblNumOfSeats.Name = "lblNumOfSeats";
            this.lblNumOfSeats.Size = new System.Drawing.Size(87, 13);
            this.lblNumOfSeats.TabIndex = 13;
            this.lblNumOfSeats.Text = "Number of seats:";
            // 
            // lblOverallPrice
            // 
            this.lblOverallPrice.AutoSize = true;
            this.lblOverallPrice.Location = new System.Drawing.Point(221, 390);
            this.lblOverallPrice.Name = "lblOverallPrice";
            this.lblOverallPrice.Size = new System.Drawing.Size(66, 13);
            this.lblOverallPrice.TabIndex = 14;
            this.lblOverallPrice.Text = "Overall price";
            // 
            // nudNumOfSeats
            // 
            this.nudNumOfSeats.Location = new System.Drawing.Point(19, 407);
            this.nudNumOfSeats.Name = "nudNumOfSeats";
            this.nudNumOfSeats.Size = new System.Drawing.Size(120, 20);
            this.nudNumOfSeats.TabIndex = 15;
            this.nudNumOfSeats.ValueChanged += new System.EventHandler(this.nudNumOfSeats_ValueChanged);
            // 
            // txtOverallPrice
            // 
            this.txtOverallPrice.Location = new System.Drawing.Point(224, 406);
            this.txtOverallPrice.Name = "txtOverallPrice";
            this.txtOverallPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOverallPrice.TabIndex = 16;
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Location = new System.Drawing.Point(541, 388);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(247, 39);
            this.btnCreateReservation.TabIndex = 17;
            this.btnCreateReservation.Text = "Create reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // MainManagementReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.txtOverallPrice);
            this.Controls.Add(this.nudNumOfSeats);
            this.Controls.Add(this.lblOverallPrice);
            this.Controls.Add(this.lblNumOfSeats);
            this.Controls.Add(this.lblAvailableProjections);
            this.Controls.Add(this.lstAvailableProjections);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.cbMovies);
            this.Controls.Add(this.cbHalls);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblHall);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "MainManagementReservation";
            this.Text = "MainManagementReservation";
            this.Load += new System.EventHandler(this.MainManagementReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.ComboBox cbHalls;
        private System.Windows.Forms.ComboBox cbMovies;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.ListBox lstAvailableProjections;
        private System.Windows.Forms.Label lblAvailableProjections;
        private System.Windows.Forms.Label lblNumOfSeats;
        private System.Windows.Forms.Label lblOverallPrice;
        private System.Windows.Forms.NumericUpDown nudNumOfSeats;
        private System.Windows.Forms.TextBox txtOverallPrice;
        private System.Windows.Forms.Button btnCreateReservation;
    }
}