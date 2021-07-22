using System;
using System.Collections.Generic;
using System.Text;
using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Models;

namespace CinemaReservationManager.Repository.Handlers
{
    public static class ErrorHandler
    {
        public static Result IsValidDto(RegisterUserDTO registerUserDTO)
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
    }
}
