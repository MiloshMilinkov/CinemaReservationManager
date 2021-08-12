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

namespace CinemaReservationManager.Application.Forms
{
    public partial class ProjectionAdministrationForm : Form
    {
        private readonly string _mode;
        private readonly Form _mdiParent;
        private readonly ProjectionRepository _projectionRepository;
        private readonly HallRepository _hallRepository;
        private readonly MovieRepository _movieRepository;
        private int _id;
        public ProjectionAdministrationForm(Form mdiParent, string mode)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _projectionRepository = new ProjectionRepository();
            _hallRepository = new HallRepository();
            _movieRepository = new MovieRepository();
        }
        public ProjectionAdministrationForm(Form mdiParent, string mode,int id)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _id = id;
            _projectionRepository = new ProjectionRepository();
            _hallRepository = new HallRepository();
            _movieRepository = new MovieRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProjectionDetailDTO projectionDetailDTO = new ProjectionDetailDTO()
            {
                ProjectionId = _id,
                ProjectionDate = dtpProjectionDate.Value,
                ProjectionStartTime=dtpProjectionStart.Value,
                TicketPrice=txtPrice.Text,
                HallId=cbHall.SelectedValue.ToString(),
                MovieId=cbMovie.SelectedValue.ToString()
            };

            Result result = null;

            if (_mode == "Add")
            {
                result = _projectionRepository.AddProjection(projectionDetailDTO);
            }
            else if (_mode == "Edit")
            {
                result = _projectionRepository.EditProjection(projectionDetailDTO);
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
            ProjectionsForms projectionsForms = new ProjectionsForms(_mdiParent);
            projectionsForms.Location = new Point(0, 0);
            projectionsForms.MdiParent = _mdiParent;
            projectionsForms.Show();
            this.Hide();
        }

        private void ProjectionAdministrationForm_Load(object sender, EventArgs e)
        {
            List<HallDetailDTO> hallDetailDTOs = _hallRepository.GetHalls();
            cbHall.DataSource = hallDetailDTOs;
            cbHall.DisplayMember = "HallNumber";
            cbHall.ValueMember = "Id";

            List<MovieDetailDTO> movieDetailDTOs = _movieRepository.GetMovies();
            cbMovie.DataSource = movieDetailDTOs;
            cbMovie.DisplayMember = "MovieName";
            cbMovie.ValueMember = "Id";

            if (_mode == "Add")
            {
                _id = 0;
            }
            else if (_mode == "Edit")
            {
                Result result = _projectionRepository.GetProjection(_id);
                if (result.IsSuccessful)
                {
                    Projection projection= (Projection)result.Object;
                    txtPrice.Text = projection.TicketPrice.ToString();
                    dtpProjectionDate.Value = projection.ProjectionDate;
                    dtpProjectionStart.Value = projection.ProjectionStartTime;
                    cbHall.SelectedValue = projection.HallId;
                    cbMovie.SelectedValue = projection.MovieId;
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }
}
