using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Ganre { get; set; }
        public int MovieLenght { get; set; }
        public int AgeRestriction { get; set; }
        public override string ToString()
        {
            return Id + "|" + MovieName + "|" + Ganre + "|" + MovieLenght + "|" + AgeRestriction;
        }

    }
}
