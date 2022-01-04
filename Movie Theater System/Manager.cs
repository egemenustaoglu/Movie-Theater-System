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
                "Manager's id is : " + id);
        }
        public void ManagerPanel()
        {
            bool flag = true;
           

            while (flag)
            {
                Console.WriteLine(System.indent + "*** Welcome to Manager panel ***\n" +
                  "Press 1 to set a movie's price\n" +
                  "Press 2 to add a new movie to movie list\n" +
                  "Press 3 to add new Ticket Officer");
                int index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Movie.ListMovies();
                        Console.WriteLine("***************************************");
                        Console.WriteLine("Pick a movie to change it's price");
                        int listChoice = Convert.ToInt32(Console.ReadLine());
                        Movie chosenMovie = System.movieList[listChoice-1];
                        Console.WriteLine("Set a new price to movie " + chosenMovie.GetMovieTitle()) ;
                        double priceChoice = Convert.ToInt32(Console.ReadLine());
                        SetMoviePrice(chosenMovie, priceChoice);
                        break;
                    case 2:
                        Movie.addMovieToList();
                        break;
                    case 3:
                        TicketOfficer.createNewTicketOfiifcer();
                        break;

                }
            }
        }


    }
}
   

