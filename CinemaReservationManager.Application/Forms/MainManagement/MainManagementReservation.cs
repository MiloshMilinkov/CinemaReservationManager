using CinemaReservationManager.Repository;
using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaReservationManager.Application.Forms.MainManagement
{
    public partial class MainManagementReservation : Form
    {
        private readonly HallRepository _hallRepository;
        private readonly MovieRepository _movieRepository;
        private readonly ProjectionRepository _projectionRepository;
        private readonly ReservationRepository _reservationRepository;
        private readonly int _loggedUserId;
        private bool isFormInitialized = false;
        public MainManagementReservation(int loggedUserId)
        {
            InitializeComponent();
            _hallRepository = new HallRepository();
            _movieRepository = new MovieRepository();
            _projectionRepository = new ProjectionRepository();
            _reservationRepository = new ReservationRepository();
            _loggedUserId = loggedUserId;
        }

        private void MainManagementReservation_Load(object sender, EventArgs e)
        {
            List<HallDetailDTO> hallDetailDTOs = _hallRepository.GetHalls();
            cbHalls.DataSource = hallDetailDTOs;
            cbHalls.DisplayMember = "HallNumber";
            cbHalls.ValueMember = "Id";

            List<MovieDetailDTO> movieDetailDTOs = _movieRepository.GetMovies();
            cbMovies.DataSource = movieDetailDTOs;
            cbMovies.DisplayMember = "MovieName";
            cbMovies.ValueMember = "Id";

            List<ProjectionDetailDTO> projectionDetailDTOs = _projectionRepository.GetAvailableProjections();
            lstAvailableProjections.DataSource = projectionDetailDTOs;
            lstAvailableProjections.DisplayMember = "DisplayProperty";
            lstAvailableProjections.ValueMember = "ProjectionId";

            dtpDateFrom.MinDate = DateTime.Now;
            dtpDateTo.MinDate = DateTime.Now;

            isFormInitialized = true;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<ProjectionDetailDTO> projectionDetailDTOs = _projectionRepository
                .GetFilteredProjections(dtpDateFrom.Value,
                                        dtpDateTo.Value,
                                        int.Parse(cbHalls.SelectedValue.ToString()), 
                                        int.Parse(cbMovies.SelectedValue.ToString()));
            lstAvailableProjections.DataSource = projectionDetailDTOs;
            lstAvailableProjections.DisplayMember = "DisplayProperty";
            lstAvailableProjections.ValueMember = "ProjectionId";
        }

        private void nudNumOfSeats_ValueChanged(object sender, EventArgs e)
        {
            Result selectedProjectionResult = _projectionRepository.GetProjection(int.Parse(lstAvailableProjections.SelectedValue.ToString()));
            Projection selectedProjection = (Projection)selectedProjectionResult.Object;
            txtOverallPrice.Text = (nudNumOfSeats.Value * selectedProjection.TicketPrice).ToString();
        }

        private void lstAvailableProjections_SelectedValueChanged(object sender, EventArgs e)
        {
            if(isFormInitialized)
            {
                Result selectedProjectionResult = _projectionRepository.GetProjection(int.Parse(lstAvailableProjections.SelectedValue.ToString()));
                Projection selectedProjection = (Projection)selectedProjectionResult.Object;
                txtOverallPrice.Text = (nudNumOfSeats.Value * selectedProjection.TicketPrice).ToString();
            }
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            ReservationDetailDTO reservationDetailDTO = new ReservationDetailDTO()
            {
                StandardUserId = _loggedUserId.ToString(),
                ProjectionId = lstAvailableProjections.SelectedValue.ToString(),
                NumberOfSeats = nudNumOfSeats.Value.ToString(),
                OverallPrice = txtOverallPrice.Text
            };

            Result result=_reservationRepository.AddReservation(reservationDetailDTO);

            if (result.IsSuccessful)
            {
                MessageBox.Show("Successfully reserved!");
                MainManagementMainForm mainManagementMainForm = new MainManagementMainForm(_loggedUserId);
                mainManagementMainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
