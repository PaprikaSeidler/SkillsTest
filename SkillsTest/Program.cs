namespace SkillsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af Booking (Opgave 2):");
            Console.WriteLine("--------------------------");

            //Booking b1 = new Booking(101, new DateTime(2024, 6, 21, 14, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 16);
            //Booking b2 = new Booking(102, new DateTime(2024, 6, 25, 10, 0, 0), new DateTime(2024, 6, 25, 11, 30, 0), 16);
            //Booking b3 = new Booking(103, new DateTime(2024, 6, 22, 13, 0, 0), new DateTime(2024, 6, 25, 14, 0, 0), 16);

            Booking b1 = new Booking(new DateTime(2024, 6, 21, 14, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 16);
            Booking b2 = new Booking(new DateTime(2024, 6, 25, 10, 0, 0), new DateTime(2024, 6, 25, 11, 30, 0), 16);
            Booking b3 = new Booking(new DateTime(2024, 6, 22, 13, 0, 0), new DateTime(2024, 6, 22, 14, 0, 0), 16);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af GymHall (Opgave 3):");
            Console.WriteLine("--------------------------");

            GymHall g1 = new GymHall(1, "Small Gymhall", "Hårlev", "10101010", "smg@email.com");
            Console.WriteLine(g1);
            GymHall g2 = new GymHall(2, "Large Gymhall", "Hårlev", "20202020", "xlg@email.com");
            Console.WriteLine(g2);

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af CRUD (Opgave 4):");
            Console.WriteLine("--------------------------");

            //test af RegisterBooking
            g1.RegisterBooking(b1);
            g2.RegisterBooking(b2);
            g2.RegisterBooking(b3);

            // PrintBookings
            Console.WriteLine("Bookings for g1:");
            g1.PrintBookings();

            Console.WriteLine("Bookings for g2:");
            g2.PrintBookings();

            // RemoveBooking
            g1.RemoveBooking(b1);
            g2.RemoveBooking(b2);

            // PrintBookings
            Console.WriteLine("Bookings for g1:\n");
            g1.PrintBookings();

            Console.WriteLine("Bookings for g2:");
            g2.PrintBookings();

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af BookingDurationOK (Opgave 6):");
            Console.WriteLine("--------------------------");

            //Booking b5 = new Booking(105, new DateTime(2024, 6, 21, 17, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 16);
            Booking b5 = new Booking(new DateTime(2024, 6, 21, 17, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 16);
            Console.WriteLine($"Is booking valid?: {b5.BookingDurationOK}");

            //Booking b6 = new Booking(106, new DateTime(2024, 6, 16, 10, 0, 0), new DateTime(2024, 6, 16, 12, 0, 0), 16);
            Booking b6 = new Booking(new DateTime(2024, 6, 16, 10, 0, 0), new DateTime(2024, 6, 16, 12, 0, 0), 16);
            Console.WriteLine($"Is booking valid?: {b6.BookingDurationOK}");

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af IsSundayBooking (Opgave 6):");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"Is it a sunday?: {b5.IsSundayBooking}");
            Console.WriteLine($"Is it a sunday?: {b6.IsSundayBooking}");

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af TotalBookings (Opgave 6):");
            Console.WriteLine("--------------------------");

            GymHall g3 = new GymHall(3, "Popular Gymhall", "Hårlev", "10101010", "pg@email.com");


            g3.RegisterBooking(b5);
            g3.RegisterBooking(b6);

            Console.WriteLine($"Total bookings for g1: {g1.TotalBookings}");
            Console.WriteLine($"Total bookings for g2: {g2.TotalBookings}");
            Console.WriteLine($"Total bookings for g3: {g3.TotalBookings}");

            //Console.WriteLine("--------------------------");
            //Console.WriteLine(" Test af Validerings funktioner (Opgave 7):");
            //Console.WriteLine("--------------------------");

            //Booking b7 = new Booking(107, new DateTime(2024, 6, 21, 10, 0, 0), new DateTime(2024, 6, 21, 18, 0, 0), 16);
            //Booking b8 = new Booking(108, new DateTime(2024, 6, 25, 10, 0, 0), new DateTime(2024, 6, 25, 9, 0, 0), 13);
            //Booking b9 = new Booking(109, new DateTime(2024, 6, 22, 13, 0, 0), new DateTime(2024, 6, 25, 14, 0, 0), 210);

            //g1.Validate(b7);
            //g1.Validate(b8);
            //g1.Validate(b9);

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af Exceptions (Opgave 8):");
            Console.WriteLine("--------------------------");

            try
            {
                //Booking b7 = new Booking(107, new DateTime(2024, 6, 21, 10, 0, 0), new DateTime(2024, 6, 21, 18, 0, 0), 16);
                Booking b7 = new Booking(new DateTime(2024, 6, 21, 10, 0, 0), new DateTime(2024, 6, 21, 18, 0, 0), 16);
                g1.Validate(b7);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                //Booking b8 = new Booking(108, new DateTime(2024, 6, 25, 10, 0, 0), new DateTime(2024, 6, 25, 9, 0, 0), 13);
                Booking b8 = new Booking(new DateTime(2024, 6, 25, 10, 0, 0), new DateTime(2024, 6, 25, 9, 0, 0), 13);
                g1.Validate(b8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                //Booking b9 = new Booking(109, new DateTime(2024, 6, 22, 13, 0, 0), new DateTime(2024, 6, 25, 14, 0, 0), 210);
                Booking b9 = new Booking(new DateTime(2024, 6, 22, 13, 0, 0), new DateTime(2024, 6, 22, 14, 0, 0), 210);
                g1.Validate(b9);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af User stories (Opgave 10):");
            Console.WriteLine("--------------------------");

            User u1 = new User("Paprika", "12345678", "ps@ps.com");
            Console.WriteLine(u1);

            //Uncommnet denne og Comment så alt over opgave 10 - så virker det...
            Booking AutoIDBooking1 = new Booking(new DateTime(2024, 6, 22, 13, 0, 0), new DateTime(2024, 6, 22, 14, 0, 0), 10);
            Booking AutoIDBooking2 = new Booking(new DateTime(2024, 6, 25, 13, 0, 0), new DateTime(2024, 6, 25, 14, 0, 0), 10);
            Console.WriteLine(AutoIDBooking1);
            Console.WriteLine(AutoIDBooking2);

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Test af TotalTimeBooked (Opgave 11):");
            Console.WriteLine("--------------------------");

            GymHall g11 = new GymHall(11, "Gym11", "Roskilde", "11111111", "email@email.dk");
            g11.RegisterBooking(AutoIDBooking1);
            g11.RegisterBooking(AutoIDBooking2);

            Console.WriteLine(g11.TotalTimeBooked);
            Console.WriteLine(g2.TotalTimeBooked);
        }
    }
}
