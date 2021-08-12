using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Handlers;
using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository
{
    public class MovieRepository
    {
        public Result AddMovie(MovieDetailDTO movieDetailDTO)
        {
            Result result = ErrorHandler.IsValidDto(movieDetailDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            List<Movie> movies = FileHandler.ReadAllMovies("Movie.txt");
            int newId;
            if (movies.Count == 0)
            {
                newId = 1;
            }
            else
            {
                newId = movies[movies.Count - 1].Id + 1;
            }
            Movie movie= new Movie()
            {
                Id = newId,
                MovieName = movieDetailDTO.MovieName,
                MovieLenght = int.Parse(movieDetailDTO.MovieLenght),
                Ganre = movieDetailDTO.Ganre,
                AgeRestriction = int.Parse(movieDetailDTO.AgeRestriction)
                
            };
            //Register
            FileHandler.WriteRecord("Movie.txt", movie);
            return result;
        }
        public Result EditMovie(MovieDetailDTO movieDetailDTO)
        {
           
            List<Movie> movies= FileHandler.ReadAllMovies("Movie.txt");
            Result result = ErrorHandler.IsValidDto(movieDetailDTO);

            //Input validation
            if (!result.IsSuccessful)
            {
                return result;
            }

            //Mapping
            Movie modifiedMovie = new Movie()
            {
                Id = movieDetailDTO.Id,
                MovieName = movieDetailDTO.MovieName,
                MovieLenght = int.Parse(movieDetailDTO.MovieLenght),
                Ganre = movieDetailDTO.Ganre,
                AgeRestriction = int.Parse(movieDetailDTO.AgeRestriction)
                
            };

            int listIndex = -1;

            //Find position for the modified object in standardUsers list
            for (int i = 0; i < movies.Count; i++)
            {
                if (modifiedMovie.Id == movies[i].Id)
                {
                    listIndex = i;
                }
            }

            //Switch objects in standardUsers list
            movies.RemoveAt(listIndex);
            movies.Insert(listIndex, modifiedMovie);

            //Save
            FileHandler.WriteAllRecords("Movie.txt", movies);

            return result;
        }
        public Result GetMovie(int id)
        {
            List<Movie> movies = FileHandler.ReadAllMovies("Movie.txt");
            Result result = new Result();
            foreach (var movie in movies)
            {
                if (movie.Id == id)
                {
                    result.Object = movie;
                    return result;
                }

            }
            result.IsSuccessful = false;
            result.ErrorMessage = "Movie with provided Id doesn not exist!";
            return result;
        }
        public List<MovieDetailDTO> GetMovies()
        {
            MovieDetailDTO movieDetailDTO;
            List<MovieDetailDTO> movieDetailDTOs = new List<MovieDetailDTO>();
            List<Movie> movies = FileHandler.ReadAllMovies("Movie.txt");
            foreach (var movie in movies)
            {
                movieDetailDTO = new MovieDetailDTO()
                {
                    Id = movie.Id,
                    MovieName = movie.MovieName,
                    MovieLenght= movie.MovieLenght.ToString(),
                    Ganre = movie.Ganre,
                    AgeRestriction = movie.AgeRestriction.ToString()

                };
                movieDetailDTOs.Add(movieDetailDTO);
            }
            return movieDetailDTOs;
        }

    }
}
