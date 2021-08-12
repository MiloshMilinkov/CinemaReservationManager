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
        
        public static List<StandardUser> ReadAllStandardUsers(string fileName)
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
        public static List<Admin> ReadAllAdmins(string fileName)
        {
            List<Admin> admins = new List<Admin>();
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Milosh\Desktop\" + fileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        Admin admin= new Admin()
                        {
                            Id = int.Parse(data[0]),
                            UserName = data[1],
                            Password = data[2],
                            Sex = data[3],
                            Pin = data[4]
                        };
                        admins.Add(admin);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return admins;
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
                throw;
            }
        }
        public static void WriteAllRecords(string fileName,List<StandardUser> standardUsers)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(string.Empty);
                   
                }

                using (StreamWriter sw = File.AppendText(path))
                {
                
                    foreach (var standardUser in standardUsers)
                    {
                        sw.WriteLine(standardUser.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
           
        }
        public static List<Movie> ReadAllMovies(string fileName)
        {
            List<Movie> movies= new List<Movie>();
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Milosh\Desktop\" + fileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        Movie movie = new Movie()
                        {
                            Id = int.Parse(data[0]),
                            MovieName = data[1],
                            Ganre = data[2],
                            MovieLenght = int.Parse(data[3]),
                            AgeRestriction = int.Parse(data[4])
                        };
                        movies.Add(movie);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return movies;
        }
        public static void WriteRecord(string fileName, Movie movie)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(movie.ToString());
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(movie.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void WriteAllRecords(string fileName, List<Movie> movies)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(string.Empty);

                }

                using (StreamWriter sw = File.AppendText(path))
                {

                    foreach (var movie in movies)
                    {
                        sw.WriteLine(movie.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }
        public static List<Hall> ReadAllHalls(string fileName)
        {
            List<Hall> halls= new List<Hall>();
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Milosh\Desktop\" + fileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        Hall hall = new Hall()
                        {
                            Id = int.Parse(data[0]),
                            HallNumber = int.Parse(data[1]),
                            NumberOfSeats = int.Parse(data[2])
                            
                        };
                        halls.Add(hall);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return halls;
        }
        public static void WriteRecord(string fileName, Hall hall)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(hall.ToString());
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(hall.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void WriteAllRecords(string fileName, List<Hall> halls)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(string.Empty);

                }

                using (StreamWriter sw = File.AppendText(path))
                {

                    foreach (var hall in halls)
                    {
                        sw.WriteLine(hall.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }
        public static List<Projection> ReadAllProjections(string fileName)
        {
            List<Projection> projections = new List<Projection>();
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Milosh\Desktop\" + fileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        Projection projection = new Projection()
                        {
                            ProjectionId = int.Parse(data[0]),
                            ProjectionDate = DateTime.Parse(data[1]),
                            ProjectionStartTime = DateTime.Parse(data[2]),
                            TicketPrice = int.Parse(data[3]),
                            HallId = int.Parse(data[4]),
                            MovieId= int.Parse(data[5])

                        };
                        projections.Add(projection);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return projections;
        }
        public static void WriteRecord(string fileName, Projection projection)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(projection.ToString());
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(projection.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void WriteAllRecords(string fileName, List<Projection> projections)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(string.Empty);

                }

                using (StreamWriter sw = File.AppendText(path))
                {

                    foreach (var projection in projections)
                    {
                        sw.WriteLine(projection.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }
        public static List<Reservation> ReadAllReservations(string fileName)
        {
            List<Reservation> reservations = new List<Reservation>();
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Milosh\Desktop\" + fileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        Reservation reservation = new Reservation()
                        {
                            ReservationId = int.Parse(data[0]),
                            StandardUserId = int.Parse(data[1]),
                            ProjectionId = int.Parse(data[2]),
                            NumberOfSeats = int.Parse(data[3]),
                            OverallPrice = int.Parse(data[4]),
                        };
                        reservations.Add(reservation);
                    }
                }
            }
            catch (Exception ex)
            {           
            }

            return reservations;
        }
        public static void WriteRecord(string fileName, Reservation reservation)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(reservation.ToString());
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(reservation.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void WriteAllRecords(string fileName, List<Reservation> reservations)
        {
            string path = @"C:\Users\Milosh\Desktop\" + fileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(string.Empty);

                }

                using (StreamWriter sw = File.AppendText(path))
                {

                    foreach (var reservation in reservations)
                    {
                        sw.WriteLine(reservation.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

    }
}
