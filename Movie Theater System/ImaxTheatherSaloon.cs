using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Theater.cs
    // is-a relationship *Inheritance of (Imax Theater) from Theater class.
    class ImaxTheatherSaloon : TheatherSaloon
    {
        private bool imaxIsAvailable;
        // has-a relationship RegularTheatherSaloon has a movie inside
        // We are making shallow coppie of the movie which is givven us on constructor. That why when we change movie's basePrice in MakeGeneralDiscount method (--> 46)
        //We also change the basePrice of the movie which is created in system class
        Movie movie = new Movie();

        public ImaxTheatherSaloon(int IMAXTheatherID, int IMAXSeatCount , bool ImaxIsAvailable) : base(IMAXTheatherID, IMAXSeatCount, ImaxIsAvailable)
        {
        }
        // get methods
        
        public string getMovie()
        {
            //call movie title from Moive class's getMovieTitle method which return string
            return movie.GetMovieTitle();
        }
        public bool getImaxIsAvailable()
        {
            return imaxIsAvailable;
        }
        // set methods
      
        public void SetMovie(Movie movie)
        {
            this.movie = movie;
        }
        public void SetImaxIsAvailable(bool availibilty)
        {
            imaxIsAvailable = availibilty;
        }


        //MakeGeneralDiscount() is for usage of Polymorphism
        //Override the method for the specific theater discount.
        /*public override void MakeFixedDiscount()
        {
            double basePrice = movie.GetBasePrice();
            // we take fixed discount amount with convert.ToDounle methot to make sure division calculation not return 0
            basePrice = basePrice - (basePrice * (Convert.ToDouble(10) / 100));
            movie.SetBasePrice(basePrice);
            Console.WriteLine("Base price of the movie which is shown on this saloon is set to : " + movie.GetBasePrice());
        }
        */

    }
   
}
