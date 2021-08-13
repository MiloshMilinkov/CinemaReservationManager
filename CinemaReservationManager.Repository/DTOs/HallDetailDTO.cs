using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.DTOs
{
    public class HallDetailDTO
    {
        public int Id { get; set; }
        public string HallNumber { get; set; }
        public string NumberOfSeats { get; set; }
    }
}
