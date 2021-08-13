using CinemaReservationManager.Application.Forms.MainManagement;
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

namespace CinemaReservationManager.Application.Forms.Administration
{
    public partial class ReservationAdministrationForm : Form
    {
        private readonly Form _mdiParent;
        private readonly ReservationRepository _reservationRepository;
        private readonly ProjectionRepository _projectionRepository;
        private readonly UserRepository _userRepository;
        private int _id;
        private readonly string _mode;

        public ReservationAdministrationForm(Form mdiParent, string mode)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _reservationRepository = new ReservationRepository();
            _projectionRepository = new ProjectionRepository();
            _userRepository = new UserRepository();
        }
        public ReservationAdministrationForm(Form mdiParent, string mode, int id)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _id = id;
            _reservationRepository = new ReservationRepository();
            _projectionRepository = new ProjectionRepository();
            _userRepository = new UserRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReservationDetailDTO reservationDetailDTO = new ReservationDetailDTO()
            {
                ReservationId = _id,
                StandardUserId = cmbUser.SelectedValue.ToString(),
                ProjectionId = cmbProjection.SelectedValue.ToString(),
                NumberOfSeats = txtNumberOfSeats.Text,
                OverallPrice = txtOverallPrice.Text
            };

            Result result = null;

            if (_mode == "Add")
            {
                result = _reservationRepository.AddReservation(reservationDetailDTO);
            }
            else if (_mode == "Edit")
            {
                result = _reservationRepository.EditReservation(reservationDetailDTO);
            }

            if (result.IsSuccessful)
            {
                MessageBox.Show("Successfully saved!");
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsForm = new ReservationsForm(_mdiParent);
            reservationsForm.Location = new Point(0, 0);
            reservationsForm.MdiParent = _mdiParent;
            reservationsForm.Show();
            this.Hide();
        }

        private void ReservationAdministrationForm_Load(object sender, EventArgs e)
        {
            List<ProjectionDetailDTO> projectionDetailDTOs = _projectionRepository.GetProjections();
            cmbProjection.DataSource = projectionDetailDTOs;
            cmbProjection.DisplayMember = "ProjectionDate"+ "TicketPrice";
            cmbProjection.ValueMember = "ProjectionId";

            List<UserDetailDTO> userDetailDTOs = _userRepository.GetUsers();
            cmbUser.DataSource = userDetailDTOs;
            cmbUser.DisplayMember = "UserName";
            cmbUser.ValueMember = "StandardUserId";

            if (_mode == "Add")
            {
                _id = 0;
            }
            else if (_mode == "Edit")
            {
                Result result = _reservationRepository.GetReservation(_id);
                if (result.IsSuccessful)
                {
                    Reservation reservation = (Reservation)result.Object;
                    cmbProjection.SelectedValue = reservation.ProjectionId;
                    cmbUser.SelectedValue = reservation.StandardUserId;
                    txtNumberOfSeats.Text = reservation.NumberOfSeats.ToString();
                    txtOverallPrice.Text = reservation.OverallPrice.ToString();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }
}
