using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.DTOs
{
    public class ReservationDetailDTO
    {
        public int ReservationId { get; set; }
        public string StadnardUserId { get; set; }
        public string ProjectionId { get; set; }
        public string NumberOfSeats { get; set; }
        public string OverallPrice { get; set; }
    }
}
