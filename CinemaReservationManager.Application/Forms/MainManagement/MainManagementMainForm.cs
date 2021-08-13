using CinemaReservationManager.Repository;
using CinemaReservationManager.Repository.DTOs;
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
    public partial class MainManagementMainForm : Form
    {
        private readonly int _loggedUserId;
        private readonly ReservationRepository _reservationRepository;
        public MainManagementMainForm(int loggedUserId)
        {
            InitializeComponent();
            _loggedUserId = loggedUserId;
            _reservationRepository = new ReservationRepository();
        }

        private void MainManagementMainForm_Load(object sender, EventArgs e)
        {
            List<ReservationDetailDTO> reservationDetailDTOs = _reservationRepository.GetReservationsByUser(_loggedUserId);
            lstReservations.DataSource = reservationDetailDTOs;
            lstReservations.DisplayMember = "DisplayProperty";
            lstReservations.ValueMember = "ReservationId";

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            MainManagementReservation mainManagementReservation = new MainManagementReservation(_loggedUserId);
            mainManagementReservation.Show();
            this.Close();
        }
    }
}
