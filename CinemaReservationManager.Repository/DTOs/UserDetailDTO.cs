using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CinemaReservationManager.Repository.DTOs
{

    public class UserDetailDTO
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

       
    }
}
