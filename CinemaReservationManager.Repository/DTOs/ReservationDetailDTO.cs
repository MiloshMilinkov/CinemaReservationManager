using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.DTOs
{
    public class ReservationDetailDTO
    {
        public int ReservationId { get; set; }
        public string StandardUserId { get; set; }
        public string ProjectionId { get; set; }
        public string NumberOfSeats { get; set; }
        public string OverallPrice { get; set; }
        public string DisplayProperty { get; set; }
        public void DisplayProperty_Set()
        {
            ProjectionRepository projectionRepository = new ProjectionRepository();
            Result projectionResult = projectionRepository.GetProjection(int.Parse(ProjectionId));
            Projection projection = (Projection)projectionResult.Object;

            MovieRepository movieRepository = new MovieRepository();
            Result movieResult = movieRepository.GetMovie(projection.MovieId);
            Movie movie = (Movie)movieResult.Object;

            this.DisplayProperty = $"Projection start time: {projection.ProjectionDate}, Number of seats: {NumberOfSeats}, Overall price: {OverallPrice}, Movie: {movie.MovieName}";
        }
    }
}
