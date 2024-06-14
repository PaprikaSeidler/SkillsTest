using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillsTest
{
    public class Booking
    {
        private static int _autoId = 100;
        //public int ID 
        //{ 
        //    get { return _autoId; }
        //    set { _autoId = value; }
        //}
        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Participants { get; set; }
        public bool BookingDurationOK
        { 
            get 
            {  
                if (Start.AddHours(2) > End)
                {
                    return false;
                }
                return true;
            }
        }
        public bool IsSundayBooking
        {
            get
            {
                if (Start.DayOfWeek == DayOfWeek.Sunday)
                {
                    return true;
                }
                return false;
            }
        }

        //public Booking(int id, DateTime start, DateTime end, int participants)
        //{
        //    ID = id;
        //    Start = start;
        //    End = end;
        //    Participants = participants;
        //}
        public Booking(DateTime start, DateTime end, int participants) 
        { 
            ID = AutoID();
            Start = start;
            End = end;
            Participants = participants;
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Start of booking: {Start}\n" +
                $"End of booking: {End}\n" +
                $"Number og patricipants: {Participants}\n";
        }

        public static int AutoID()
        {
            int id = _autoId++;
            return id;
        }

    }
}
