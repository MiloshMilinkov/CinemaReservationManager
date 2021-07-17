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
    public partial class WelcomeForm : Form
    {
        private readonly Form _formMdiParent;
        public WelcomeForm(Form formMdiParent)
        {
            InitializeComponent();
            _formMdiParent = formMdiParent;

        }

        private void btnLoginAsUser_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(false, _formMdiParent);
            loginForm.Location = new Point(0,0);
            loginForm.MdiParent = _formMdiParent;
            loginForm.Show();
            this.Dispose();
        }

        private void btnLoginAsAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(true, _formMdiParent);
            loginForm.Location = new Point(0, 0);
            loginForm.MdiParent = _formMdiParent;
            loginForm.Show();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_formMdiParent);
            registerForm.Location = new Point(0, 0);
            registerForm.MdiParent = _formMdiParent;
            registerForm.Show();
            this.Dispose();
        }
    }
}
