using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.Models
{
    public class Projection:Movie
    {
        public int ProjectionId { get; set; }
        public DateTime ProjectionDate { get; set; }
        public int TicketPrice { get; set; }
        public DateTime ProjectionStartTime { get; set; }
        public int HallId { get; set; }
        public int MovieId { get; set; }
        public override string ToString()
        {
            return ProjectionId + "|" + ProjectionDate + "|" + ProjectionStartTime+ "|"+ TicketPrice + "|"+ HallId + "|"+ MovieId ;
        }
    }
}
