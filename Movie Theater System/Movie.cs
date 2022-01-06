using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // For use (Class)Movie object on Manager ve implement public modifier to our class because the method(SetMoviePrice) where we use (Class)Movie object is less accessible than public method(SetMoviePrice)
    public class Movie
    {
        private string movieTitle;
        private double basePrice;
        private bool isIMAX;
        private static int movieListCounter;
        private static DateTime movieStartTime;
        private static DateTime movieEndTime;

        //Constructor
        public Movie( )
        {

        }

        public Movie(string movieTitle , double basePrice , bool isIMAX  , DateTime MovieStartTime , DateTime MovieEndTime)
        {
            try
            {
                if(basePrice > 0)
                {
                    this.basePrice = basePrice;
                }else
                {
                    throw new PriceException("You can not create a movie which it's base price is 0");
                }
            }
            catch(PriceException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            movieStartTime = MovieStartTime;
            movieEndTime = MovieEndTime;
            this.movieTitle = movieTitle;
            this.isIMAX = isIMAX;
        }

        // get methods
        public string GetMovieTitle()
        {
            return movieTitle;
        }
        public double GetBasePrice()
        {
            return basePrice;
        }
        public bool GetIsIMAX()
        {
            return isIMAX;
        }
        public string GetStartTime()
        {
            String startTimeHourMinute = movieStartTime.ToString("HH:mm");
            return startTimeHourMinute;
        }
        public string GetEndTime()
        {
            String endTimeHourMinute = movieEndTime.ToString("HH:mm");
            return endTimeHourMinute;
        }


        // set methods 
        public void SetMovieTitle(string movieTitle)
        {
            this.movieTitle = movieTitle;
        }
            // base price can't be less than 0.0
        public void SetBasePrice(double basePrice)
        {
            try
            {       // use (double) Explicit Casting to make sure we are taking double as variable. Even it is a trivial check because we take basePrice as double on parameter's method its good to be make things fixed 
                    // check if the base price is lower than zere if it is throw a exception
                if ((double)basePrice < 0.0)
                {
                    throw new PriceException("You enter a price which is belove the '0.0' .It is not allowed for ticket base pricing...");
                }
                else
                {
                    this.basePrice = basePrice;
                }
            }
            catch(PriceException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
           
        }
        public void SetIsIMAX(bool isIMAX)
        {
            this.isIMAX = isIMAX;
        }
        
        
        public static void ListMovies()
        {
            Console.WriteLine(System.indent + "***Movie List***");
            movieListCounter = 1;
            foreach (Movie movie in System.movieList)
            {
                Console.WriteLine(movieListCounter + ". Movie's informations are \n" +
                     "Title of the movie : " + movie.GetMovieTitle()+"\n" +
                     "Price of the movie : " + movie.GetBasePrice()+"\n" +
                     "Is the movie Imax  : " + movie.GetIsIMAX() + "\n" +
                     "Start Time : " + movie.GetStartTime() + "\n" +
                     "End Time : " + movie.GetEndTime());
                movieListCounter += 1;
            }
        }
        public static void addMovieToList()
        {
            try
            {
                Console.WriteLine(System.indent + "***Adding new movie***\n" +
                "Please give the Title of the movie :");
                String newMovieTitle = Console.ReadLine();
                Console.WriteLine("Please give the Base Price of the movie :");
                int newMovieBasePrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press 'T' if movie is IMAX or 'F' if the movie is not IMAX");
                String newMovieIMAX = Console.ReadLine();
                bool newMovieIMAXbool=false;
                Console.WriteLine("Give a start time for movie HH:mm:");
                string userInput = Console.ReadLine();
                string[] parsed = userInput.Split(":");
                int startHour = Convert.ToInt32(parsed[0]);
                int startMinute = Convert.ToInt32(parsed[1]);
                Console.WriteLine("Give a end time for movie HH:mm:");
                userInput = Console.ReadLine();
                parsed = userInput.Split(":");
                int endHour = Convert.ToInt32(parsed[0]);
                int endMinute = Convert.ToInt32(parsed[1]);
                movieStartTime = new DateTime(2022, 2, 1, startHour, startMinute, 0);
                movieEndTime = new DateTime(2022, 2, 1, endHour, endMinute, 0);

                if (newMovieIMAX == "t" || newMovieIMAX == "T")
                {
                    newMovieIMAXbool = true;
                }
                else if (newMovieIMAX == "f" || newMovieIMAX == "F")
                {
                    newMovieIMAXbool = false;
                }
                else
                {
                    throw new PriceException("Your input is invalid");
                }
                Movie addNewMovie = new Movie(newMovieTitle, newMovieBasePrice, newMovieIMAXbool , movieStartTime , movieEndTime);
                Console.WriteLine("Your new movie is created.");
                try
                {
                    System.movieList.Add(addNewMovie);
                }
                catch(Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("There is a problem occure while your movie is added to Movie list and this is the error message :\n" +
                        ""+e.Message);
                    Console.ResetColor();
                }
                
            }
            catch (PriceException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            Console.WriteLine("Your new movie is added to list");

        }
    }

    // Exception if the base price of a movie is below the 0.0
    public class PriceException : Exception
    {
        public PriceException (string message) : base(message)
        {

        }
    }
}
