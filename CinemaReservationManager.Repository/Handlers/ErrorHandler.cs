using System;
using System.Collections.Generic;
using System.Text;
using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Models;

namespace CinemaReservationManager.Repository.Handlers
{
    public static class ErrorHandler
    {
        public static Result IsValidDto(UserDetailDTO registerUserDTO)
        {
            Result result = new Result();
            result.ErrorMessage = "Please enter: ";


            if (string.IsNullOrEmpty(registerUserDTO.UserName))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "User name";
            }
            if (string.IsNullOrEmpty(registerUserDTO.Password))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Password";
            }
            if (string.IsNullOrEmpty(registerUserDTO.FirstName))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "First name";
            }
            if (string.IsNullOrEmpty(registerUserDTO.LastName))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Last name";
            }
            if (string.IsNullOrEmpty(registerUserDTO.PhoneNumber))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Phone number";
            }
            return result;
        }
        public static Result IsValidDto(LoginUserDTO loginUserDTO)
        {
            Result result = new Result();
            result.ErrorMessage = "Please enter: ";
            if (string.IsNullOrEmpty(loginUserDTO.UserName))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "User name";
            }
            if (string.IsNullOrEmpty(loginUserDTO.Password))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Password";
            }
            return result;
        }
        public static Result IsValidDto(LoginAdminDTO loginAdminDTO)
        {
            Result result = new Result();
            result.ErrorMessage = "Please enter: ";
            if (string.IsNullOrEmpty(loginAdminDTO.UserName))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "User name ";
            }
            if (string.IsNullOrEmpty(loginAdminDTO.PinPassword))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Pin+Password";
            }
            return result;
        }
        public static Result IsValidDto(MovieDetailDTO movieDetailDTO)
        {
            Result result = new Result();
            result.ErrorMessage = "Please enter: ";


            if (string.IsNullOrEmpty(movieDetailDTO.MovieName))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Movie name";
            }
            if (string.IsNullOrEmpty(movieDetailDTO.Ganre))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Ganre";
            }
            if (string.IsNullOrEmpty(movieDetailDTO.MovieLenght))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Movie lenght";
            }
            if (string.IsNullOrEmpty(movieDetailDTO.AgeRestriction))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Age restriction";
            }

            return result;
        }
        public static Result IsValidDto(HallDetailDTO hallDetailDTO)
        {
            Result result = new Result();
            result.ErrorMessage = "Please enter: ";


            if (string.IsNullOrEmpty(hallDetailDTO.HallNumber))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Hall number";
            }
            if (string.IsNullOrEmpty(hallDetailDTO.NumberOfSeats))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Number of seats";
            }
            return result;
        }
        public static Result IsValidDto(ProjectionDetailDTO projectionDetailDTO)
        {
            Result result = new Result();
            result.ErrorMessage = "Please enter: ";
            if (string.IsNullOrEmpty(projectionDetailDTO.HallId))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Hall";
            }
            if (string.IsNullOrEmpty(projectionDetailDTO.MovieId))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Movie";
            }
            if (string.IsNullOrEmpty(projectionDetailDTO.TicketPrice))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Ticket price";
            }
            return result;
        }
        public static Result IsValidDto(ReservationDetailDTO reservationDetailDTO)
        {
            Result result = new Result();
            result.ErrorMessage = "Please enter: ";
            if (string.IsNullOrEmpty(reservationDetailDTO.StandardUserId))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += " the Customer";
            }
            if (string.IsNullOrEmpty(reservationDetailDTO.ProjectionId))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "the Projection";
            }
            if (string.IsNullOrEmpty(reservationDetailDTO.NumberOfSeats))
            {
                result.IsSuccessful = false;
                result.ErrorMessage += "Number of seats";
            }
            //if (string.IsNullOrEmpty(reservationDetailDTO.OverallPrice))
            //{
            //    result.IsSuccessful = false;
            //    result.ErrorMessage += "Overall price";
            //}

            return result;
        }
    }
}