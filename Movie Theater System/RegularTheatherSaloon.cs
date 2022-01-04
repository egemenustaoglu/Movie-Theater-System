using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Theater.cs
    // is-a relationship *Inheritance of (Regular Theater) from Theater class.
    class RegularTheatherSaloon : TheatherSaloon
    {
        private bool rIsAvailable;
        // has-a relationship RegularTheatherSaloon has a movie inside
        // We are making shallow coppie of the movie which is givven us on constructor. That why when we change movie's basePrice in MakeGeneralDiscount method (--> 44)
        //We also change the basePrice of the movie which is created in system class
        Movie movie = new Movie();
        


        public RegularTheatherSaloon(int RTheatherID, int RSeatCount , bool RIsAvailable , Movie Movie) : base(RTheatherID , RSeatCount , RIsAvailable)
        {
            movie = Movie;
        }

        // get methods
        public string GetMovie()
        {
            return movie.GetMovieTitle();
        }
        public bool getRIsAvailable()
        {
            return rIsAvailable;
        }
        // set methods

        public void SetMovie(Movie movie)
        {
            this.movie = movie;
        }
        public void SetRegularTheatherIsAvaliable(bool availibilty)
        {
            rIsAvailable = availibilty;
        }

        //MakeGeneralDiscount() is for usage of Polymorphism
        //Override the method for the specific theater discount.
        public override void MakeFixedDiscount()
        {
            double basePrice = movie.GetBasePrice();
            // we take fixed discount amount with convert.ToDounle methot to make sure division calculation not return 0
            basePrice = basePrice - (basePrice * (Convert.ToDouble(15)/ 100));
            movie.SetBasePrice(basePrice);
            Console.WriteLine("Base price of the movie which is shown on this saloon is set to : " + movie.GetBasePrice());
           
            }


        }
   
}
