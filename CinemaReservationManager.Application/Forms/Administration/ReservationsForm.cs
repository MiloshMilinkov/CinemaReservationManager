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

namespace CinemaReservationManager.Application.Forms.Administration
{
    public partial class ReservationsForm : Form
    {
        private readonly Form _mdiParent;
        private readonly ReservationRepository _reservationRepository;
        public ReservationsForm(Form mdiParent)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _reservationRepository = new ReservationRepository();
        }

       

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            ReservationAdministrationForm reservationAdministrationForm = new ReservationAdministrationForm(_mdiParent, "Add");
            reservationAdministrationForm.Location = new Point(0, 0);
            reservationAdministrationForm.MdiParent = _mdiParent;
            reservationAdministrationForm.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReservationAdministrationForm reservationAdministrationForm = new ReservationAdministrationForm(_mdiParent, "Edit", int.Parse(lstReservations.SelectedValue.ToString()));
            reservationAdministrationForm.Location = new Point(0, 0);
            reservationAdministrationForm.MdiParent = _mdiParent;
            reservationAdministrationForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministrationNavigationForm administrationNavigationForm = new AdministrationNavigationForm(_mdiParent);
            administrationNavigationForm.Location = new Point(0, 0);
            administrationNavigationForm.MdiParent = _mdiParent;
            administrationNavigationForm.Show();
            this.Hide();
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            List<ReservationDetailDTO> reservationDetailDTOs = _reservationRepository.GetReservations();
            lstReservations.DataSource = reservationDetailDTOs;
            lstReservations.DisplayMember = "DisplayProperty";
            lstReservations.ValueMember = "ReservationId";
        }
    }
}
