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
    public partial class HallsForm : Form
    {
        private readonly Form _mdiParent;
        private readonly HallRepository _hallRepository;
        public HallsForm(Form mdiParent)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _hallRepository = new HallRepository();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministrationNavigationForm administrationNavigationForm = new AdministrationNavigationForm(_mdiParent);
            administrationNavigationForm.Location = new Point(0, 0);
            administrationNavigationForm.MdiParent = _mdiParent;
            administrationNavigationForm.Show();
            this.Hide();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            HallAdministrationForm hallAdministrationForm = new HallAdministrationForm(_mdiParent, "Edit", int.Parse(lstHalls.SelectedValue.ToString()));
            hallAdministrationForm.Location = new Point(0, 0);
            hallAdministrationForm.MdiParent = _mdiParent;
            hallAdministrationForm.Show();
            this.Hide();
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            HallAdministrationForm hallAdministrationForm = new HallAdministrationForm(_mdiParent, "Add");
            hallAdministrationForm.Location = new Point(0, 0);
            hallAdministrationForm.MdiParent = _mdiParent;
            hallAdministrationForm.Show();
            this.Hide();
        }

        private void HallsForm_Load(object sender, EventArgs e)
        { 
                List<HallDetailDTO> hallDetailDTOs = _hallRepository.GetHalls();
                lstHalls.DataSource = hallDetailDTOs;
                lstHalls.DisplayMember = "HallNumber";
                lstHalls.ValueMember = "Id";
        }
    }
}
