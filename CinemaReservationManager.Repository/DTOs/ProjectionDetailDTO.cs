using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.DTOs
{
    public class ProjectionDetailDTO
    {
        public int ProjectionId { get; set; }
        public DateTime ProjectionDate { get; set; }
        public string TicketPrice { get; set; }
        public DateTime ProjectionStartTime { get; set; }
        public string HallId { get; set; }
        public string MovieId { get; set; }
    }
}
