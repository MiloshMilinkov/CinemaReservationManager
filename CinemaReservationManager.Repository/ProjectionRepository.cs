using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Handlers;
using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository
{
    public class ProjectionRepository
    {
        public Result AddProjection(ProjectionDetailDTO projectionDetailDTO)
        {
            Result result = ErrorHandler.IsValidDto(projectionDetailDTO);
            if (!result.IsSuccessful)
            {
                return result;
            }
            List<Projection> projections = FileHandler.ReadAllProjections("Projection.txt");
            int newId;
            if (projections.Count == 0)
            {
                newId = 1;
            }
            else
            {
                newId = projections[projections.Count - 1].ProjectionId + 1;
            }
            Projection projection = new Projection()
            {
                ProjectionId = newId,
                ProjectionDate = projectionDetailDTO.ProjectionDate,
                ProjectionStartTime = projectionDetailDTO.ProjectionStartTime,
                TicketPrice =int.Parse(projectionDetailDTO.TicketPrice),
                HallId = int.Parse(projectionDetailDTO.HallId),
                MovieId = int.Parse(projectionDetailDTO.MovieId)

            };
            //Register
            FileHandler.WriteRecord("Projection.txt", projection);
            return result;
        }
        public Result EditProjection(ProjectionDetailDTO projectionDetailDTO)

        {

            List<Projection> projections = FileHandler.ReadAllProjections("Projection.txt");
            Result result = ErrorHandler.IsValidDto(projectionDetailDTO);

            //Input validation
            if (!result.IsSuccessful)
            {
                return result;
            }

            //Mapping
            Projection modifiedProjection = new Projection()
            {
                ProjectionId = projectionDetailDTO.ProjectionId,
                ProjectionDate = projectionDetailDTO.ProjectionDate,
                ProjectionStartTime = projectionDetailDTO.ProjectionStartTime,
                TicketPrice = int.Parse(projectionDetailDTO.TicketPrice),
                HallId = int.Parse(projectionDetailDTO.HallId),
                MovieId = int.Parse(projectionDetailDTO.MovieId)
            };

            int listIndex = -1;

            //Find position for the modified object in standardUsers list
            for (int i = 0; i < projections.Count; i++)
            {
                if (modifiedProjection.ProjectionId == projections[i].ProjectionId)
                {
                    listIndex = i;
                }
            }

            //Switch objects in standardUsers list
            projections.RemoveAt(listIndex);
            projections.Insert(listIndex, modifiedProjection);

            //Save
            FileHandler.WriteAllRecords("Projection.txt", projections);

            return result;
        }
        public Result GetProjection(int id)
        {
            List<Projection> projections = FileHandler.ReadAllProjections("Projection.txt");
            Result result = new Result();
            foreach (var projection in projections)
            {
                if (projection.ProjectionId == id)
                {
                    result.Object = projection;
                    return result;
                }

            }
            result.IsSuccessful = false;
            result.ErrorMessage = "Projection with provided Id does not exist!";
            return result;
        }
        public List<ProjectionDetailDTO> GetProjections()
        {
            ProjectionDetailDTO projectionDetailDTO;
            List<ProjectionDetailDTO> projectionDetailDTOs = new List<ProjectionDetailDTO>();
            List<Projection> projections = FileHandler.ReadAllProjections("Projection.txt");
            foreach (var projection in projections)
            {
                projectionDetailDTO = new ProjectionDetailDTO()
                {
                    ProjectionId= projection.ProjectionId,
                    ProjectionDate= projection.ProjectionDate,
                    ProjectionStartTime=projection.ProjectionStartTime,
                    HallId=projection.HallId.ToString(),
                    MovieId=projection.MovieId.ToString(),
                    TicketPrice=projection.TicketPrice.ToString()

                };
                projectionDetailDTOs.Add(projectionDetailDTO);
            }
            return projectionDetailDTOs;
        }
    }
}
