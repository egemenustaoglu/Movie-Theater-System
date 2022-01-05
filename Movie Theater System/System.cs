using System;
using System.Collections;
using System.Collections.Generic;

namespace Movie_Theater_System
{
    class System
    {
        public static string indent = new string(' ', 4);
        public static List<Movie> movieList = new List<Movie>();
        public static List<TicketOfficer> ticketOfficerList = new List<TicketOfficer>();
        public static List<TheatherSaloon> theatherSaloonList = new List<TheatherSaloon>();
        public static List<Customer> customerList = new List<Customer>();
        static void Main(string[] args)
        {
            Movie mov = new Movie("Egemen sikmece", 100, false);
                Movie mov2 = new Movie("burak sikmece", 90, true);
                Movie mov3 = new Movie("ali sikmece", 80, false);
                Movie mov4 = new Movie("Atakan sikmece", 70, true);
                Movie mov5 = new Movie("gerald sikmece", 60, false);
            movieList.Add(mov);
            movieList.Add(mov2);
            movieList.Add(mov3);
            movieList.Add(mov4);
            // We create our Theather Saloons before we go to Movie Theather System's panel
            TheatherSaloon.CreateTheatherSaloons();
            
            bool flag = true;   

            Customer cust = new ChildCustomer("Atakan",23, 110);
            while (flag)
            {
                Console.WriteLine("*** Welcome to Movie Theather Sysytem ***\n" +
                  "Press 1 to go Manager panel.\n" +
                  "Press 2 to go Ticket officer panel\n" +
                  "Press 3 to continue with Customer panel\n" +
                  "Press 4 to exit from Movie Theather System");
                int index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Manager.ManagerPanel();
                        break;
                    case 2:
                        TicketOfficer.TicketOfficerPanel();
                        break;
                    case 3:
                        cust.CustomerPanel();
                        break;
                    case 4:
                        Console.WriteLine("You are exiting from Movie Theather Sysytem ... \n" +
                            "Have a nice day.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You enter wrong input please select an input from list");
                        break;
                }
            }
            
           /* Movie mov = new Movie("Egemen sikmece", 100 , false);
            Manager manager = Manager.GetManager();
            TicketOfficer ticketOfficer1 = new TicketOfficer("Egemen" ,2);
            UserTest(manager);
            Customer cust = new AdultCustomer( "atakan akyazs", 24);
            UserTest(ticketOfficer1);
            TicketOfficer ticketOfficer2 = new TicketOfficer("Egemen" ,3);
            UserTest(ticketOfficer2);
            TicketOfficer ticketOfficer3 = new TicketOfficer("Egemen" ,14);
            UserTest(ticketOfficer3);

            RegularTheatherSaloon saloon = new RegularTheatherSaloon(1,10,true,mov);
            Console.WriteLine(saloon.GetID() + " " + saloon.GetSeat() + " " + saloon.GetMovie() );
            */
            /*
            Console.WriteLine(mov.GetBasePrice());s
            mov.SetBasePrice(2);
            Console.WriteLine(mov.GetBasePrice());
            manager.SetMoviePrice(mov, -3.5);
            Console.WriteLine(mov.GetBasePrice());
            */
           
            /*TheatherSaloon theather = new RegularTheatherSaloon(1 , 10 , true , mov );
            MakeDiscount(theather);
            Console.WriteLine(mov.GetBasePrice());
            */
        }

        //Here we create a method for display the user's information and this method call printInfo method from the User then by the type of user (Manager , ticketofficer or customer)
        //it display differet type of overrided printInfo methods . This is polymorphism 
        public static void UserInformation(User user)   
        {
            user.PrintInfo();
        }
        //This is a polymorphism method. Depend on the which type of saloon (RegularTheatherSaloon or ImacTheatherSaloon) we give to method , it will make a different amount of discounts
        public static void MakeDiscount(Customer customer , Movie mov)
        {
            customer.MakeDiscount(mov);
        }
    }
}
