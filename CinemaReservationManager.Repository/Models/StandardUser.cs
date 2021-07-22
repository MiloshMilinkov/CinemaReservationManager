using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.Models
{
    public class StandardUser:User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return Id+"|"+UserName + "|" + Password + "|" + Sex + "|" + FirstName + "|" + LastName + "|" + BirthDate + "|" + PhoneNumber;
        }
    }
}
