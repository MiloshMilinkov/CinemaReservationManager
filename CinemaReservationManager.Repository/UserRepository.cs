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
        public Result Register(UserDetailDTO userDetailDTO)
        {
            
            //Input validation
            Result result = ErrorHandler.IsValidDto(userDetailDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            //Check if user exists
            if (!IsUserNameAvailable(userDetailDTO.UserName))
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
                UserName = userDetailDTO.UserName,
                LastName = userDetailDTO.LastName,
                Password=userDetailDTO.Password,
                BirthDate=userDetailDTO.BirthDate,
                FirstName=userDetailDTO.FirstName,
                Sex=userDetailDTO.Sex,
                PhoneNumber=userDetailDTO.PhoneNumber    
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
        public Result EditUser(UserDetailDTO userDetailDTO) 
        {
            int oldId=0;
            List<StandardUser> standardUsers = FileHandler.ReadAllStandardUsers("StandardUser.txt");
            Result result = ErrorHandler.IsValidDto(userDetailDTO);

            //Input validation
            if (!result.IsSuccessful)
            {
                return result;
            }

            //Find old Id
            foreach (var standardUser in standardUsers)
            {
                if (userDetailDTO.UserName == standardUser.UserName)
                {
                    oldId = standardUser.Id;
                }
            }

            if (oldId == 0)
            {
                result.IsSuccessful = false;
                result.ErrorMessage = "Some error occured.";
                return result;

            }

            //Mapping
            StandardUser modifiedStandardUser = new StandardUser()
            {
                Id = oldId,
                UserName = userDetailDTO.UserName,
                LastName = userDetailDTO.LastName,
                Password = userDetailDTO.Password,
                BirthDate = userDetailDTO.BirthDate,
                FirstName = userDetailDTO.FirstName,
                Sex = userDetailDTO.Sex,
                PhoneNumber = userDetailDTO.PhoneNumber
            };

            int listIndex=-1; 

            //Find position for the modified object in standardUsers list
            for (int i = 0; i < standardUsers.Count; i++)
            {
                if (modifiedStandardUser.UserName == standardUsers[i].UserName)
                {
                    listIndex = i;
                }
            }

            //Switch objects in standardUsers list
            standardUsers.RemoveAt(listIndex);
            standardUsers.Insert(listIndex,modifiedStandardUser);

            //Save
            FileHandler.WriteAllRecords("StandardUser.txt", standardUsers);

            return result;
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
                    result.Object = standardUser;
                    return result;

                }
                
            }
            result.IsSuccessful = false;
            result.ErrorMessage = "Invalid login details";
            return result;

        }
        public List<UserDetailDTO> GetUsers()
        {
            UserDetailDTO userDetailDTO;
            List<UserDetailDTO> userDetailDTOs = new List<UserDetailDTO>() ;
            List<StandardUser> standardUsers = FileHandler.ReadAllStandardUsers("StandardUser.txt");
            foreach (var standardUser in standardUsers)
            {
                userDetailDTO = new UserDetailDTO()
                {
                    StandardUserId=standardUser.Id,
                    UserName = standardUser.UserName,
                    Password = standardUser.Password,
                    FirstName = standardUser.FirstName,
                    LastName = standardUser.LastName,
                    Sex = standardUser.Sex,
                    PhoneNumber = standardUser.PhoneNumber,
                    BirthDate = standardUser.BirthDate
                };
                userDetailDTOs.Add(userDetailDTO);
            }
            return userDetailDTOs;
        }        
        public Result GetUser(string userName)
        {
            List<StandardUser> standardUsers = FileHandler.ReadAllStandardUsers("StandardUser.txt");
            Result result = new Result();
            foreach (var standardUser in standardUsers)
            {
                if (standardUser.UserName == userName)
                {
                    result.Object = standardUser;
                    return result;
                }
                
            }
            result.IsSuccessful = false;
            result.ErrorMessage = "User with provided username does not exist!";
            return result;

        }
    }
}
