using CinemaReservationManager.Application.Forms.Administration;
using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository;
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
    public partial class ProjectionsForms : Form
    {
        private readonly Form _mdiParent;
        private readonly ProjectionRepository _projectionRepository;
        public ProjectionsForms(Form mdiParent)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _projectionRepository = new ProjectionRepository();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministrationNavigationForm administrationNavigationForm = new AdministrationNavigationForm(_mdiParent);
            administrationNavigationForm.Location = new Point(0, 0);
            administrationNavigationForm.MdiParent = _mdiParent;
            administrationNavigationForm.Show();
            this.Hide();
        }

        private void btnAddProjection_Click(object sender, EventArgs e)
        {
            ProjectionAdministrationForm projectionAdministrationForm = new ProjectionAdministrationForm(_mdiParent, "Add");
            projectionAdministrationForm.Location = new Point(0, 0);
            projectionAdministrationForm.MdiParent = _mdiParent;
            projectionAdministrationForm.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ProjectionAdministrationForm projectionAdministrationForm = new ProjectionAdministrationForm(_mdiParent, "Edit",int.Parse(lstProjections.SelectedValue.ToString()));
            projectionAdministrationForm.MdiParent = _mdiParent;
            projectionAdministrationForm.Show();
            this.Hide();
        }
       

        private void ProjectionsForms_Load(object sender, EventArgs e)
        {
            List<ProjectionDetailDTO> projectionDetailDTOs = _projectionRepository.GetProjections();
            lstProjections.DataSource = projectionDetailDTOs;
            lstProjections.DisplayMember = "ProjectionDate";
            lstProjections.ValueMember = "ProjectionId";
        }
    }
}
