using Movie_Theater_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from User.cs
    // is-a relationship *Inheritance of (Manager) from User class.
    public class Manager : User
    {
        private Movie managerMovie = new Movie();
        private TicketOfficer managerTicketOfficer = new TicketOfficer();
        private int id;
        private static string managerPassword = "M135";
        // we use singleton patter to make sure we have only 1 manager with id 0
        private static Manager singletonManager = null;
        private Manager(String Name , int Age) : base(Name , Age)
        {
            id = 0;
        }
        // get methods
        // When we do method static it becomes class's method and we can use it by just using class's ( Manager manager = Manager.GetManager() )like this
        public static Manager GetManager()
        {
            if(singletonManager == null)
            {
                Console.WriteLine("Please enter name and surname for your manager");
                string fullName = Console.ReadLine();
                Console.WriteLine("Please enter age for your manager");
                int age = Convert.ToInt32(Console.ReadLine());
                singletonManager = new Manager(fullName , age);
            }
                return singletonManager;
            
        }
        public static void SetMoviePrice(Movie movie, double price)
        {
            movie.SetBasePrice(price);
        }

        //printInfo() is for usage of Polymorphism
        //Override the method for the specific user type.
        public override void PrintInfo()
        {
            Console.WriteLine("Manager's name is : " + GetName() + "\n" +
                 "Manager's age is: " + GetAge() + "\n" +
                "Manager's id is : " + id);
        }
        public static void ManagerPanel()  
        {
            bool flag = false;
            Console.WriteLine("Please enter the Manager's password to continue with Manager panel");
            string enteredPassword = Console.ReadLine();
            if (enteredPassword.Equals(managerPassword))
            {
                flag = true;
            }
            else
            {
                Console.WriteLine("You entered wrong password");
            }
            while (flag)
            {
                Console.WriteLine(System.indent + "*** Welcome to Manager panel ***\n" +
                  "Press 1 to set a movie's price\n" +
                  "Press 2 to add a new movie to movie list\n" +
                  "Press 3 to list all movies\n" +
                  "Press 4 to delete movie" +
                  "Press 5 to add new Ticket Officer\n" +
                  "Press 6 to set new Information to existing Ticket Officer\n" +
                  "Press 7 to print Ticket Officeers\n" +
                  "Press 8 to delete Ticket Officer" +
                  "Press 9 to to print information of manager\n" +
                  "Press 10 to set new Informations to existing Theather\n" +
                  "Press 11 to Exit from Manager Panel\n");
                int index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Movie.ListMovies();
                        Console.WriteLine("***************************************");
                        Console.WriteLine("Pick a movie to change it's price");
                        int listChoice = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (listChoice < System.movieList.Count +1)
                            {
                                throw new UserException("You should select a valid input");
                            }
                            
                                Movie chosenMovie = System.movieList[listChoice - 1];
                                Console.WriteLine("Set a new price to movie " + chosenMovie.GetMovieTitle());
                                double priceChoice = Convert.ToInt32(Console.ReadLine());
                                SetMoviePrice(chosenMovie, priceChoice);
                        }catch(UserException e)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(e.Message);
                            Console.ResetColor();
                        }
                       
                        break;
                    case 2:
                        Movie.addMovieToList();
                        break;
                    case 3:
                        Movie.ListMovies();
                        break;
                    case 4:
                        Movie.ListMovies();
                        Console.WriteLine("Select the movie you want to remove");
                        int deleteChoice = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if(deleteChoice < System.movieList.Count)
                            {
                                throw new UserException("You should select a valid input");
                            }
                            System.movieList.RemoveAt(deleteChoice-1);
                        }
                        catch (UserException e)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(e.Message);
                            Console.ResetColor();
                        }
                        break;
                    case 5:
                        TicketOfficer.CreateNewTicketOfiifcer();
                        break;
                    case 6:
                        TicketOfficer.ChangeTicketOfficer();
                        break;
                    case 7:
                        Console.WriteLine(System.indent + "***Printing Ticket Officers***");
                        foreach (TicketOfficer ticketOfficer in System.ticketOfficerList)
                        {
                            Console.Write("*");
                            System.UserInformation(ticketOfficer);
                        }
                        break;
                    case 8:
                        Movie.ListMovies();
                        Console.WriteLine("Select the Ticket Officer you want to remove");
                        int deleteTciketOfficerChoice = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (deleteTciketOfficerChoice < System.ticketOfficerList.Count)
                            {
                                throw new UserException("You should select a valid input");
                            }
                            System.movieList.RemoveAt(deleteTciketOfficerChoice - 1);
                        }
                        catch (UserException e)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(e.Message);
                            Console.ResetColor();
                        }
                        break;
                    case 9:
                        System.UserInformation(Manager.GetManager());
                        break;
                    case 10:
                        TheatherSaloon.ChangeSaloonInformation();
                        break;
                    case 11:
                        Console.WriteLine("Exiting from manager panel");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You Should enter a valid input");
                        break;

                }
            }
        }


    }
}
   

