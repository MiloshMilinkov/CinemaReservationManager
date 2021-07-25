using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Models;
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

namespace CinemaReservationManager.Application
{
    public partial class RegisterForm : Form
    {
        private readonly Form _formMdiParent;
        private readonly UserRepository _userRepository;
        public RegisterForm(Form formMdiParent)
        {
            InitializeComponent();
            _formMdiParent = formMdiParent;
            _userRepository = new UserRepository();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(_formMdiParent);
            welcomeForm.Location = new Point(0, 0);
            welcomeForm.MdiParent = _formMdiParent;
            welcomeForm.Show();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text==txtRepeatPassword.Text)
            {
                UserDetailDTO registerUserDTO = new UserDetailDTO()
                {
                    UserName = txtUserName.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtpBirthDate.Value,
                    PhoneNumber = txtPhoneNumber.Text,
                    Password = txtPassword.Text,
                    Sex = rbMale.Checked ? "Male" : "Female"
                };
                Result result = _userRepository.Register(registerUserDTO);
                if (result.IsSuccessful)
                {
                    MessageBox.Show("Registration successful!");
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
           
        }
    }
}
