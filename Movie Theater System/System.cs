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
            UserTest(TicketOfficer);
            Customer cust = new AdultCustomer(24 , "atakan akyazs");

            Movie mov = new Movie(1.0);
            Console.WriteLine(mov.GetBasePrice());
            mov.SetBasePrice(2);
            Console.WriteLine(mov.GetBasePrice());
            manager.SetMoviePrice(mov, -3.5);
            Console.WriteLine(mov.GetBasePrice());

        }

        //Here we create a method for show polymorphism 
        public static void UserTest(User user)
        {
            user.PrintInfo();
        }
       
        
    }
}
