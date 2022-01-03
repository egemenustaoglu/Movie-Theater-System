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
        //Constructor
        public Movie( )
        {

        }
        public Movie(string movieTitle)
        {
            this.movieTitle = movieTitle;
        }

        public Movie(double basePrice)
        {
            this.basePrice = basePrice;
        }

        public Movie(string movieTitle , double basePrice)
        {
            this.basePrice = basePrice;
            this.movieTitle = movieTitle;
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

    }

    // Exception if the base price of a movie is below the 0.0
    public class PriceException : Exception
    {
        public PriceException (string message) : base(message)
        {

        }
    }
}
