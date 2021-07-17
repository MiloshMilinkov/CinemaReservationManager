using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaReservationManager.Application
{
    public partial class RegisterForm : Form
    {
        private readonly Form _formMdiParent;
        public RegisterForm(Form formMdiParent)
        {
            InitializeComponent();
            _formMdiParent = formMdiParent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(_formMdiParent);
            welcomeForm.Location = new Point(0, 0);
            welcomeForm.MdiParent = _formMdiParent;
            welcomeForm.Show();
            this.Dispose();
        }
    }
}
