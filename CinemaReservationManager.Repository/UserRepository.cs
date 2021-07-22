using System;
using System.Collections.Generic;
using System.Text;
using CinemaReservationManager.Repository.Models;
using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Handlers;

namespace CinemaReservationManager.Repository
{
    public class UserRepository
    {
        public Result Register(RegisterUserDTO registerUserDTO)
        {
            
            //Input validation
            Result result = ErrorHandler.IsValidDto(registerUserDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            //Check if user exists
            if (!IsUserNameAvailable(registerUserDTO.UserName))
            {
                result.IsSuccessful = false;
                result.ErrorMessage = "Username already taken.";
                return result;
            }
            //Generate new Id
            List<StandardUser> standardUsers = FileHandler.ReadAllStandardUsers("StandardUser.txt");
            int newId;
            if(standardUsers.Count==0)
            {
                newId = 1;
            }
            else
            {
                newId = standardUsers[standardUsers.Count - 1].Id + 1;
            }
            StandardUser standardUser = new StandardUser() {
                Id = newId,
                UserName = registerUserDTO.UserName,
                LastName = registerUserDTO.LastName,
                Password=registerUserDTO.Password,
                BirthDate=registerUserDTO.BirthDate,
                FirstName=registerUserDTO.FirstName,
                Sex=registerUserDTO.Sex,
                PhoneNumber=registerUserDTO.PhoneNumber    
            };
            //Register
            FileHandler.WriteRecord("StandardUser.txt", standardUser);
            return result;

        }
        public bool IsUserNameAvailable(String userName)
        {
            foreach (var standardUser in FileHandler.ReadAllStandardUsers("StandardUser.txt"))
            {
                if (standardUser.UserName == userName)
                {
                    return false;
                }

            }
            return true;
        }
        public Result Login(LoginUserDTO loginUserDTO)
        {
            Result result = ErrorHandler.IsValidDto(loginUserDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            foreach (var standardUser in FileHandler.ReadAllStandardUsers("StandardUser.txt"))
            {
                if (standardUser.UserName == loginUserDTO.UserName && standardUser.Password== loginUserDTO.Password)
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
