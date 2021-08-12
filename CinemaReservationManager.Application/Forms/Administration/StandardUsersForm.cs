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
    public partial class StandardUsersForm : Form
    {
        private readonly Form _mdiParent;
        private readonly UserRepository _userRepository;

       public StandardUsersForm(Form mdiParent)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _userRepository = new UserRepository();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                AdministrationNavigationForm administrationNavigationForm = new AdministrationNavigationForm(_mdiParent);
                administrationNavigationForm.Location = new Point(0, 0);
                administrationNavigationForm.MdiParent = _mdiParent;
                administrationNavigationForm.Show();
                this.Hide();
            

        }

        private void StandardUsersForm_Load(object sender, EventArgs e)
        {
            List<UserDetailDTO> userDetailDTOs = _userRepository.GetUsers();
            lstStandardUsers.DataSource = userDetailDTOs;
            lstStandardUsers.DisplayMember = "UserName";
            lstStandardUsers.ValueMember = "UserName";
            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StandardUserAdministrationForm standardUserAdministrationForm = new StandardUserAdministrationForm(_mdiParent, lstStandardUsers.SelectedValue.ToString());
            standardUserAdministrationForm.MdiParent = _mdiParent;
            standardUserAdministrationForm.Location = new Point(0, 0);
            standardUserAdministrationForm.Show();
            this.Hide();
        }
    }
}
