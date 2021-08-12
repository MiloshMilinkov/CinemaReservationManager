
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
    public partial class MoviesForm : Form
    {
        private readonly Form _mdiParent;
        private readonly MovieRepository _movieRepository;
        public MoviesForm(Form mdiParent)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _movieRepository = new MovieRepository();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministrationNavigationForm administrationNavigationForm = new AdministrationNavigationForm(_mdiParent);
            administrationNavigationForm.Location = new Point(0, 0);
            administrationNavigationForm.MdiParent = _mdiParent;
            administrationNavigationForm.Show();
            this.Hide();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            MovieAdministrationForm movieAdministrationForm = new MovieAdministrationForm(_mdiParent, "Add");
            movieAdministrationForm.Location = new Point(0, 0);
            movieAdministrationForm.MdiParent = _mdiParent;
            movieAdministrationForm.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MovieAdministrationForm movieAdministrationForm = new MovieAdministrationForm(_mdiParent, "Edit",int.Parse(lstMovies.SelectedValue.ToString()));
            movieAdministrationForm.Location = new Point(0, 0);
            movieAdministrationForm.MdiParent = _mdiParent;
            movieAdministrationForm.Show();
            this.Hide();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            List<MovieDetailDTO> movieDetailDTOs = _movieRepository.GetMovies();
            lstMovies.DataSource = movieDetailDTOs;
            lstMovies.DisplayMember = "MovieName";
            lstMovies.ValueMember = "Id";
        }
    }
}
