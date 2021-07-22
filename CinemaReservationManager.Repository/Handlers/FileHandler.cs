using CinemaReservationManager.Repository.DTOs;
using CinemaReservationManager.Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CinemaReservationManager.Repository.Handlers
{
    public static class FileHandler
    {
        
        public static List<StandardUser> ReadAllRecords(string fileName)
        {
            List<StandardUser> standardUsers=new List<StandardUser>();    
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Milosh\Desktop\" + fileName)) { 
                    while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');
                            StandardUser standardUser = new StandardUser()
                            {
                                Id = int.Parse(data[0]),
                                UserName = data[1],
                                Password = data[2],
                                Sex = data[3],
                                FirstName = data[4],
                                LastName = data[5],
                                BirthDate = DateTime.Parse(data[6]),
                                PhoneNumber = data[7]

                             };
                            standardUsers.Add(standardUser);
                        }
                    
                       }
                   
            }
            catch(Exception ex)
            {

            }
        
            return standardUsers;
        }
        public static void WriteRecord(string fileName, StandardUser standardUser)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(standardUser.ToString());
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(standardUser.ToString());
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
