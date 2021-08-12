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
    public partial class AdministrationNavigationForm : Form
    {
        private readonly Form _mdiParent;
        public AdministrationNavigationForm(Form mdiParent)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
        }

        private void btnStandardUserAdministration_Click(object sender, EventArgs e)
        {
            StandardUsersForm standardUsersForm = new StandardUsersForm(_mdiParent);
            standardUsersForm.MdiParent = _mdiParent;
            standardUsersForm.Location = new Point(0, 0);
            standardUsersForm.Show();
            this.Hide();
        }

        private void btnMovieAdministration_Click(object sender, EventArgs e)
        {
            MoviesForm movieForm = new MoviesForm(_mdiParent);
            movieForm.MdiParent = _mdiParent;
            movieForm.Location = new Point(0, 0);
            movieForm.Show();
            this.Hide();
        }

        private void btnHallAdministration_Click(object sender, EventArgs e)
        {
            HallsForm hallsForm = new HallsForm(_mdiParent);
            hallsForm.MdiParent = _mdiParent;
            hallsForm.Location = new Point(0, 0);
            hallsForm.Show();
            this.Hide();
        }

        private void btnProjectionAdministration_Click(object sender, EventArgs e)
        {
            ProjectionsForms projectionsForms = new ProjectionsForms(_mdiParent);
            projectionsForms.MdiParent = _mdiParent;
            projectionsForms.Location = new Point(0, 0);
            projectionsForms.Show();
            this.Hide();
        }

        private void btnReservationAdministration_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsForm = new ReservationsForm(_mdiParent);
            reservationsForm.MdiParent = _mdiParent;
            reservationsForm.Location = new Point(0, 0);
            reservationsForm.Show();
            this.Hide();
        }
    }
}
