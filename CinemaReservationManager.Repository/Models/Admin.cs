using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.Models
{
    public class Admin:User
    {
        public string Pin { get; set; }
    }
}
