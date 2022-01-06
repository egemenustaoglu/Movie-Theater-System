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
        public static int customerCounter;
        static void Main(string[] args)
        {
            // We create our Theather Saloons before we go to Movie Theather System's panel
            TheatherSaloon.CreateTheatherSaloons();
            // Creating some customer to show in presentation
            Customer customer1 = new ChildCustomer("Batuhan" , 7 , 50);
            Customer customer2 = new StudentCustomer("Zeynep", 17 , 120);
            Customer customer3 = new AdultCustomer("Hüsnü" , 23 , 70);
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            // Creating some movies to show in presentation
            DateTime movieStartTime1 = new DateTime(2022, 2, 1, 13, 30, 0);
            DateTime movieEndTime1 = new DateTime(2022, 2, 1, 15 , 30, 0);
            Movie movie1 = new Movie("Avatar" , 40 , true , movieStartTime1 , movieEndTime1);

            movieList.Add(movie1);

            bool flag = true;   
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
                        Manager.GetManager();
                        Manager.ManagerPanel();
                        break;
                    case 2:
                        TicketOfficer.TicketOfficerPanel();
                        break;
                    case 3:
                        Console.WriteLine(System.indent + "***Printing Customers***");
                        customerCounter = 1;
                        foreach (Customer customer in System.customerList)
                        {
                            Console.Write(customerCounter+". "+ customer.GetName()+"\n");
                            customerCounter += 1;
                        }
                        Console.WriteLine("Please pick your customer ...");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        customerList[choose - 1].CustomerPanel();
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
