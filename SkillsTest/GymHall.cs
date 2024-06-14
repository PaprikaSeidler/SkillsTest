using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class GymHall
    {
        private Dictionary<int, Booking> bookings;
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int TotalBookings
        {
            get { return bookings.Count; }
        }
        public TimeSpan TotalTimeBooked 
        { 
            get
            {
                TimeSpan TotalTimeBooked = TimeSpan.Zero;
                foreach (Booking booking in bookings.Values)
                {
                    TimeSpan tSpan = booking.End - booking.Start;
                    TotalTimeBooked += tSpan;
                }
                return TotalTimeBooked;
            }
        
        }

        public GymHall(int id, string name, string address, string phone, string email) 
        { 
            ID = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            bookings = new Dictionary<int, Booking>();
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Name: {Name}\n" +
                $"Address: {Address}\n" +
                $"Phone number: {Phone} \n" +
                $"Email: {Email} \n";
        }

        public void RegisterBooking(Booking booking)
        {
            bookings.Add(booking.ID, booking);
        }

        public void PrintBookings()
        {
            foreach (Booking booking in bookings.Values)
            {
                Console.WriteLine(booking);
            }
        }

        public void RemoveBooking(Booking booking)
        {
            bookings.Remove(booking.ID);
        }

        public bool Validate(Booking booking)
        {
            string message = "";

            if (!booking.BookingDurationOK)
            {
                //message = "Booking is not valid - maximum time is 2 hours";
                //Console.WriteLine(message);
                //return false;

                throw new Exception("Booking is not valid - maximum time is 2 hours");
                
            }
            if (booking.Start <= booking.End)
            {
                //message = "Booking is not valid - Starttime must be before endtime";
                //Console.WriteLine(message);
                //return false;

                throw new Exception("Booking is not valid - Starttime must be before endtime");
 
            }
            if (booking.Participants > 22)
            {
                //message = "Booking is not valid - max 22 participants";
                //Console.WriteLine(message);
                //return false;

                throw new Exception("Booking is not valid - max 22 participants");
            }
            return true;
        }
    }
}
