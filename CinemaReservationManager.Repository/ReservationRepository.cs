using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Handlers;
using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository
{
    public class ReservationRepository
    {
        public Result AddReservation(ReservationDetailDTO reservationDetailDTO)
        {
            Result result = ErrorHandler.IsValidDto(reservationDetailDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            List<Reservation> reservations = FileHandler.ReadAllReservations("Reservation.txt");
            int newId;
            if (reservations.Count == 0)
            {
                newId = 1;
            }
            else
            {
                newId = reservations[reservations.Count - 1].ReservationId + 1;
            }
            Reservation reservation = new Reservation()
            {
                ReservationId = newId,
                StandardUserId = int.Parse(reservationDetailDTO.StadnardUserId),
                ProjectionId = int.Parse(reservationDetailDTO.ProjectionId),
                NumberOfSeats= int.Parse(reservationDetailDTO.NumberOfSeats),
                OverallPrice= int.Parse(reservationDetailDTO.OverallPrice)
            };
            //Register
            FileHandler.WriteRecord("Reservation.txt", reservation);
            return result;
        }
        public Result EditReservation(ReservationDetailDTO reservationDetailDTO)
        {

            List<Reservation> reservations = FileHandler.ReadAllReservations("Reservation.txt");
            Result result = ErrorHandler.IsValidDto(reservationDetailDTO);

            //Input validation
            if (!result.IsSuccessful)
            {
                return result;
            }

            //Mapping
            Reservation modifiedReservation = new Reservation()
            {
                ReservationId = reservationDetailDTO.ReservationId,
                StandardUserId = int.Parse(reservationDetailDTO.StadnardUserId),
                ProjectionId = int.Parse(reservationDetailDTO.ProjectionId),
                NumberOfSeats = int.Parse(reservationDetailDTO.NumberOfSeats),
                OverallPrice = int.Parse(reservationDetailDTO.OverallPrice)
            };

            int listIndex = -1;

            //Find position for the modified object in standardUsers list
            for (int i = 0; i < reservations.Count; i++)
            {
                if (modifiedReservation.ReservationId == reservations[i].ReservationId)
                {
                    listIndex = i;
                }
            }

            //Switch objects in standardUsers list
            reservations.RemoveAt(listIndex);
            reservations.Insert(listIndex, modifiedReservation);

            //Save
            FileHandler.WriteAllRecords("Reservation.txt", reservations);

            return result;
        }
        public Result GetReservation(int id)
        {
            List<Reservation> reservations = FileHandler.ReadAllReservations("Reservation.txt");
            Result result = new Result();
            foreach (var reservation in reservations)
            {
                if (reservation.ReservationId == id)
                {
                    result.Object = reservation;
                    return result;
                }

            }
            result.IsSuccessful = false;
            result.ErrorMessage = "Reservation with provided Id does not exist!";
            return result;
        }
        public List<ReservationDetailDTO> GetReservations()
        {
            ReservationDetailDTO reservationDetailDTO;
            List<ReservationDetailDTO> reservationDetailDTOs = new List<ReservationDetailDTO>();
            List<Reservation> reservations = FileHandler.ReadAllReservations("Reservation.txt");
            foreach (var reservation in reservations)
            {
                reservationDetailDTO = new ReservationDetailDTO()
                {
                    ReservationId = reservation.ReservationId,
                    StadnardUserId = reservation.StandardUserId.ToString(),
                    ProjectionId = reservation.ProjectionId.ToString(),
                    NumberOfSeats= reservation.NumberOfSeats.ToString(),
                    OverallPrice= reservation.OverallPrice.ToString()


                };
                reservationDetailDTOs.Add(reservationDetailDTO);
            }
            return reservationDetailDTOs;
        }
    }
}
