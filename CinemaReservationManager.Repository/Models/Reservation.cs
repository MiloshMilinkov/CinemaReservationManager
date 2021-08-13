using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int StandardUserId { get; set; }
        public int ProjectionId { get; set; }
        public int NumberOfSeats { get; set; }
        public int OverallPrice { get; set; }
        public override string ToString()
        {
            return ReservationId + "|" + StandardUserId + "|" + ProjectionId + "|" + NumberOfSeats + "|" + OverallPrice;
        }
    }
}
