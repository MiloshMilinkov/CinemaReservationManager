using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Handlers;
using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository
{
    public class HallRepository
    {
        public Result AddHall(HallDetailDTO hallDetailDTO)
        {
            Result result = ErrorHandler.IsValidDto(hallDetailDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            List<Hall> halls = FileHandler.ReadAllHalls("Hall.txt");
            int newId;
            if (halls.Count == 0)
            {
                newId = 1;
            }
            else
            {
                newId = halls[halls.Count - 1].Id + 1;
            }
            Hall hall = new Hall()
            {
                Id = newId,
                HallNumber = int.Parse(hallDetailDTO.HallNumber),
                NumberOfSeats = int.Parse(hallDetailDTO.NumberOfSeats)
            };
            //Register
            FileHandler.WriteRecord("Hall.txt", hall);
            return result;
        }
        public Result EditHall(HallDetailDTO hallDetailDTO)
        {

            List<Hall> halls = FileHandler.ReadAllHalls("Hall.txt");
            Result result = ErrorHandler.IsValidDto(hallDetailDTO);

            //Input validation
            if (!result.IsSuccessful)
            {
                return result;
            }

            //Mapping
            Hall modifiedHall = new Hall()
            {
                Id = hallDetailDTO.Id,
                HallNumber = int.Parse(hallDetailDTO.HallNumber),
                NumberOfSeats = int.Parse(hallDetailDTO.NumberOfSeats)
            };

            int listIndex = -1;

            //Find position for the modified object in standardUsers list
            for (int i = 0; i < halls.Count; i++)
            {
                if (modifiedHall.Id == halls[i].Id)
                {
                    listIndex = i;
                }
            }

            //Switch objects in standardUsers list
            halls.RemoveAt(listIndex);
            halls.Insert(listIndex, modifiedHall);

            //Save
            FileHandler.WriteAllRecords("Hall.txt", halls);

            return result;
        }
        public Result GetHall(int id)
        {
            List<Hall> halls = FileHandler.ReadAllHalls("Hall.txt");
            Result result = new Result();
            foreach (var hall in halls)
            {
                if (hall.Id == id)
                {
                    result.Object = hall;
                    return result;
                }

            }
            result.IsSuccessful = false;
            result.ErrorMessage = "Hall with provided Id doesn not exist!";
            return result;
        }
        public List<HallDetailDTO> GetHalls()
        {
            HallDetailDTO hallDetailDTO;
            List<HallDetailDTO> hallDetailDTOs = new List<HallDetailDTO>();
            List<Hall> halls = FileHandler.ReadAllHalls("Hall.txt");
            foreach (var hall in halls)
            {
                hallDetailDTO = new HallDetailDTO()
                {
                    Id = hall.Id,
                    HallNumber= hall.HallNumber.ToString(),
                    NumberOfSeats = hall.NumberOfSeats.ToString(),
                   

                };
                hallDetailDTOs.Add(hallDetailDTO);
            }
            return hallDetailDTOs;
        }
    }
}
