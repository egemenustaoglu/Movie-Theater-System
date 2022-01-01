using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Theater.cs
    // is-a relationship *Inheritance of (Regular Theater) from Theater class.
    class RegularTheatherSaloon : TheatherSaloon
    {
        private int rTheatherID;
        private int rSeatCount;
        private bool rIsAvailable;
        // has-a relationship ImaxTheather has a movie inside
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
        // set methods
        
        public void SetMovie(Movie movie)
        {
            this.movie = movie;
        }
        public void SetRegularTheatherIsAvaliable(bool availibilty)
        {
            rIsAvailable = availibilty;
        }

        //isTheaterAvaliable() is for usage of Polymorphism
        //Override the method for the specific theater condition.
        public override bool IsTheaterAvaliable()
        {
            return rIsAvailable;
        }


    }
   
}
