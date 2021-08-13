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
    public partial class MovieAdministrationForm : Form
    {
        private readonly string _mode;
        private readonly Form _mdiParent;
        private readonly MovieRepository _movieRepository;
        private int _id;

        public MovieAdministrationForm(Form mdiParent, string mode)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _movieRepository = new MovieRepository();
        }
        public MovieAdministrationForm(Form mdiParent, string mode,int id)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _id = id;
            _movieRepository = new MovieRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            MovieDetailDTO movieDetailDTO = new MovieDetailDTO()
            {
                Id = _id,
                MovieName = txtMovieName.Text,
                Ganre = txtGanre.Text,
                MovieLenght = txtMovieLenght.Text,
                AgeRestriction = txtAgeRestriction.Text,

            };

            Result result=null;

            if (_mode == "Add")
            {
                result = _movieRepository.AddMovie(movieDetailDTO);
            }
            else if(_mode == "Edit")
            {
                result = _movieRepository.EditMovie(movieDetailDTO);
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
                MoviesForm movieForm = new MoviesForm(_mdiParent);
                movieForm.Location = new Point(0, 0);
                movieForm.MdiParent = _mdiParent;
                movieForm.Show();
                this.Hide();
        }

        private void MovieAdministrationForm_Load(object sender, EventArgs e)
        {
            if (_mode == "Add")
            {
                _id = 0;
            }
            else if (_mode == "Edit")
            {
                Result result = _movieRepository.GetMovie(_id);
                if (result.IsSuccessful)
                {
                    Movie movie = (Movie)result.Object;
                    txtMovieName.Text = movie.MovieName;
                    txtMovieLenght.Text = movie.MovieLenght.ToString();
                    txtGanre.Text = movie.Ganre;
                    txtAgeRestriction.Text = movie.AgeRestriction.ToString();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }

}
