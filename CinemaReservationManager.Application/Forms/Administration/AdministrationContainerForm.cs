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
    public partial class AdministrationContainerForm : Form
    {
        private readonly string _loggedUserName;
        public AdministrationContainerForm(string loggedUserName)
        {
            InitializeComponent();
            _loggedUserName = loggedUserName;
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            lblLoggedAdmin.Text += " " + _loggedUserName;
            AdministrationNavigationForm administrationNavigationForm = new AdministrationNavigationForm(this);
            administrationNavigationForm.MdiParent = this;
            administrationNavigationForm.Location = new Point(0, 0);
            administrationNavigationForm.Show();
        }
    }
}
