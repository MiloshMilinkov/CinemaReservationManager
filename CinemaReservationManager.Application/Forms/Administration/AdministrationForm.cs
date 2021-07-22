﻿using System;
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
    public partial class AdministrationForm : Form
    {
        private readonly string _loggedUserName;
        public AdministrationForm(string loggedUserName)
        {
            InitializeComponent();
            _loggedUserName = loggedUserName;
        }
    }
}
