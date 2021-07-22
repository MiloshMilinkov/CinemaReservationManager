using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Handlers;
using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository
{
    public class AdminRepository
    {
        public Result Login(LoginAdminDTO loginAdminDTO)
        {
            Result result = ErrorHandler.IsValidDto(loginAdminDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            foreach (var admin in FileHandler.ReadAllAdmins("Admin.txt"))
            {
                if (loginAdminDTO.UserName==admin.UserName && loginAdminDTO.PinPassword==(admin.Pin+admin.Password))
                {
                    result.IsSuccessful = true;
                    return result;
                }
            }
            result.IsSuccessful = false;
            result.ErrorMessage = "Invalid login details";
            return result;
        }
    }
}
