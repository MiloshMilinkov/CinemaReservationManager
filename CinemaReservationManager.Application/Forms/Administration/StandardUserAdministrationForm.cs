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

namespace CinemaReservationManager.Application.Forms.Administration
{
    public partial class StandardUserAdministrationForm : Form
    {
        private readonly Form _mdiParent;
        private readonly string _userName;
        private readonly UserRepository _userRepository;
        public StandardUserAdministrationForm(Form mdiParent,string userName)
        {
            InitializeComponent();
            _mdiParent = mdiParent;
            _userName = userName;
            _userRepository = new UserRepository();
        }

        private void StandardUserAdministrationForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Manage: " + _userName;
            Result result = _userRepository.GetUser(_userName);
            if (result.IsSuccessful)
            {
                StandardUser standardUser = (StandardUser)result.Object;
                txtUserName.Text = standardUser.UserName;
                txtFirstName.Text = standardUser.FirstName;
                txtLastName.Text = standardUser.LastName;
                txtPhoneNumber.Text = standardUser.PhoneNumber;
                txtRepeatPassword.Text = standardUser.Password;
                dtpBirthDate.Value = standardUser.BirthDate;
                txtPassword.Text = standardUser.Password;

                if (standardUser.Sex=="Male")
                {
                    rbMale.Checked=true;
                }
                else
                {
                    rbFemale.Checked = true;
                }  
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtRepeatPassword.Text)
            {
                UserDetailDTO userDetailDTO = new UserDetailDTO()
                {
                    UserName = txtUserName.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtpBirthDate.Value,
                    PhoneNumber = txtPhoneNumber.Text,
                    Password = txtPassword.Text,
                    Sex = rbMale.Checked ? "Male" : "Female"
                };
                Result result = _userRepository.EditUser(userDetailDTO);
                if (result.IsSuccessful)
                {
                    MessageBox.Show("Successfully saved!");
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
