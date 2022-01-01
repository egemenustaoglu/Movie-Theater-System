using System;

namespace Movie_Theater_System
{
    class System
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Atakan", 1);
            TicketOfficer TicketOfficer = new TicketOfficer("Egemen", 2);
            UserTest(manager);
            Customer cust = new AdultCustomer(24, "atakan akyazs");
            UserTest(TicketOfficer);
            Movie mov = new Movie("Egemen sikmece");
            RegularTheatherSaloon saloon = new RegularTheatherSaloon(1,10,true,mov);
            Console.WriteLine(saloon.GetID() + " " + saloon.GetSeat() + " " + saloon.GetMovie() + " " + saloon.IsTheaterAvaliable());
            /*
            Console.WriteLine(mov.GetBasePrice());s
            mov.SetBasePrice(2);
            Console.WriteLine(mov.GetBasePrice());
            manager.SetMoviePrice(mov, -3.5);
            Console.WriteLine(mov.GetBasePrice());
            */
        }

        //Here we create a method for show polymorphism 
        public static void UserTest(User user)
        {
            user.PrintInfo();
        }
    }
}
