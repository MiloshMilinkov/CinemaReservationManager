using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaReservationManager.Repository.Models
{
    public class Result
    {
        public Result()
        {
            IsSuccessful = true;
        }
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
       

    }
}
