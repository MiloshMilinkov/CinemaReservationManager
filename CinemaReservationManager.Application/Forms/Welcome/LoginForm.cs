﻿using System;
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
    public partial class LoginForm : Form
    {
        private readonly bool _isAdminLogin;
        private readonly Form _formMdiParent;
        public LoginForm(bool isAdminLogin,Form formMdiParent)
        {
            InitializeComponent();
            _isAdminLogin = isAdminLogin;
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text += (_isAdminLogin) ? " as Admin" : " as User";
            //if (_isAdminLogin)
            //{
            //    lblLogin.Text += " as Admin";
            //}
            //else
            //{
            //    lblLogin.Text += " as User";
            //}
        }
    }
}