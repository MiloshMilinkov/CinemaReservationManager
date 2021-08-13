using CinemaReservationManager.Repository.Models;
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
        public string DisplayProperty { get; set; }
        public void DisplayProperty_Set()
        {
            HallRepository hallRepository = new HallRepository();
            Result hallResult=hallRepository.GetHall(int.Parse(HallId));
            Hall hall = (Hall)hallResult.Object;

            MovieRepository movieRepository = new MovieRepository();
            Result movieResult = movieRepository.GetMovie(int.Parse(MovieId));
            Movie movie = (Movie)movieResult.Object;

            this.DisplayProperty = $"Projection date: {ProjectionDate}, Projection start time: {ProjectionStartTime},Ticket price: {TicketPrice}, Hall: {hall.HallNumber}, Movie: {movie.MovieName}";
        }
    }
}
