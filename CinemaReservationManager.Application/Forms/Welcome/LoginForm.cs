using CinemaReservationManager.Application.Forms.Administration;
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

namespace CinemaReservationManager.Application
{
    public partial class LoginForm : Form
    {
        private readonly bool _isAdminLogin;
        private readonly Form _formMdiParent;
        private readonly UserRepository _userRepository;
        private readonly AdminRepository _adminRepository;
        public LoginForm(bool isAdminLogin,Form formMdiParent)
        {
            InitializeComponent();
            _isAdminLogin = isAdminLogin;
            _formMdiParent = formMdiParent;
            _userRepository = new UserRepository();
            _adminRepository = new AdminRepository();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_isAdminLogin)
            {
                LoginAdminDTO loginAdminDTO = new LoginAdminDTO()
                {
                    UserName = txtUserName.Text,
                    PinPassword = txtPassword.Text
                };
                Result result = _adminRepository.Login(loginAdminDTO);
                if (result.IsSuccessful)
                {
                    MessageBox.Show("Login successful!");
                    AdministrationContainerForm administrationForm = new AdministrationContainerForm(loginAdminDTO.UserName);
                    administrationForm.Show();
                    _formMdiParent.Hide();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
            else
            {
                LoginUserDTO loginUserDTO = new LoginUserDTO()
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text
                };
                Result result = _userRepository.Login(loginUserDTO);
                if (result.IsSuccessful)
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }
}
