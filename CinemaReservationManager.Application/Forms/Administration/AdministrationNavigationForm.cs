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
    }
}
