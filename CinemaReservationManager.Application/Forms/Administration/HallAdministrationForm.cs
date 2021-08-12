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
    public partial class HallAdministrationForm : Form
    {
        private readonly string _mode;
        private readonly Form _mdiParent;
        private readonly HallRepository _hallRepository;
        private int _id;
        public HallAdministrationForm(Form mdiParent, string mode)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _hallRepository = new HallRepository();
        }
        public HallAdministrationForm(Form mdiParent, string mode,int id)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _mode = mode;
            _id = id;
            _hallRepository = new HallRepository();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            HallsForm hallsForm = new HallsForm(_mdiParent);
            hallsForm.Location = new Point(0, 0);
            hallsForm.MdiParent = _mdiParent;
            hallsForm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HallDetailDTO hallDetailDTO = new HallDetailDTO()
            {
                Id = _id,
                HallNumber = txtHallNumber.Text,
                NumberOfSeats = txtNumberOfSeats.Text
            };

            Result result = null;

            if (_mode == "Add")
            {
                result = _hallRepository.AddHall(hallDetailDTO);
            }
            else if (_mode == "Edit")
            {
                result = _hallRepository.EditHall(hallDetailDTO);
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

        private void HallAdministrationForm_Load(object sender, EventArgs e)
        {
            if (_mode == "Add")
            {
                _id = 0;
            }
            else if (_mode == "Edit")
            {
                Result result = _hallRepository.GetHall(_id);
                if (result.IsSuccessful)
                {
                    Hall hall = (Hall)result.Object;
                    txtHallNumber.Text = hall.HallNumber.ToString();
                    txtNumberOfSeats.Text = hall.NumberOfSeats.ToString();

                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }
}
