using System;

namespace Movie_Theater_System
{
    class System
    {
        static void Main(string[] args)
        {
            /*Manager manager = new Manager("Atakan", 1);
            TicketOfficer TicketOfficer = new TicketOfficer("Egemen", 2);
            UserTest(manager);
            Customer cust = new AdultCustomer( "atakan akyazs", 24);
            UserTest(TicketOfficer);
            
            RegularTheatherSaloon saloon = new RegularTheatherSaloon(1,10,true,mov);
            Console.WriteLine(saloon.GetID() + " " + saloon.GetSeat() + " " + saloon.GetMovie() );
            
            *//*
            Console.WriteLine(mov.GetBasePrice());s
            mov.SetBasePrice(2);
            Console.WriteLine(mov.GetBasePrice());
            manager.SetMoviePrice(mov, -3.5);
            Console.WriteLine(mov.GetBasePrice());
            */
            Movie mov = new Movie("Egemen sikmece" , 100);
            TheatherSaloon theather = new RegularTheatherSaloon(1 , 10 , true , mov );
           
            MakeDiscount(theather);
            Console.WriteLine(mov.GetBasePrice());

        }

        //Here we create a method for show polymorphism 
        public static void UserTest(User user)
        {
            user.PrintInfo();
        }
        //This is a polymorphism method. Depend on the which type of saloon (RegularTheatherSaloon or ImacTheatherSaloon) we give to method it will make a different amount of discounts
        public static void MakeDiscount(TheatherSaloon saloon )
        {
            saloon.MakeFixedDiscount();
        }
    }
}
