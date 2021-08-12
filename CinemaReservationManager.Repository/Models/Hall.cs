using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public int HallNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public override string ToString()
        {
            return Id + "|" + HallNumber + "|" + NumberOfSeats ;
        }
    }
}
