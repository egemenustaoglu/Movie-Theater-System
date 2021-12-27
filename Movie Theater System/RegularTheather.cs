using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Theater.cs
    // is-a relationship *Inheritance of (Regular Theater) from Theater class.
    class RegularTheather : Theather
    {
        private int rTheatherID;
        private int rSeatCount;
        private bool rIsAvailable;
        // has-a relationship ImaxTheather has a movie inside
        Movie movie = new Movie();


        public RegularTheather(int RTheatherID, int RSeatCount , bool RIsAvailable , Movie Movie)
        {
            rTheatherID = RTheatherID;
            rSeatCount = RSeatCount;
            rIsAvailable = RIsAvailable;
            movie = Movie;
        }

        // get methods
        public override int getID()
        {
            return rTheatherID;
        }

        public override int getSeat()
        {
            return rSeatCount;
        }
        public string getMovie()
        {
            return movie.getMovieTitle();
        }
      
        // set methods
        public override void setID(int index)
        {
            if(index >= 1)
            {
                rTheatherID = index;
            }
            else
            {
                Console.WriteLine("You should enter above 0 "); ;
            }
        }

        public override void setSeat(int index)
        {
            if (index >= 1)
            {
                rSeatCount = index;
            }
            else
            {
                Console.WriteLine("You should enter above 0 "); ;
            }
        }
        public void setMovie(Movie movie)
        {
            this.movie = movie;
        }

        //SANKI BU METOD BURDA OLMAMALI
        public void setImaxIsAvailable(bool availibilty)
        {
            rIsAvailable = availibilty;
        }

        //isTheaterAvaliable() is for usage of Polymorphism
        //Override the method for the specific theater condition.
        public override bool isTheaterAvaliable()
        {
            return rIsAvailable;
        }

    }
}
