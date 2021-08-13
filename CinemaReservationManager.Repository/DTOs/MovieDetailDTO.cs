using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.DTOs
{
    public class MovieDetailDTO
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Ganre { get; set; }
        public string MovieLenght { get; set; }
        public string AgeRestriction { get; set; }
    }
}
