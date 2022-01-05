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
        


        public RegularTheatherSaloon(int RTheatherID, int RSeatCount , bool RIsAvailable) : base(RTheatherID , RSeatCount , RIsAvailable)
        {
        }

        // get methods
        public Movie GetMovie()
        {
            return movie;
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
        }
   
}
