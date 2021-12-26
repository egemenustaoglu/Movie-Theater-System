using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    //is-a relationship inherit (child) from Theather
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
        public override bool isThatherAvailable()
        {
            return rIsAvailable;
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
        public void setImaxIsAvailable(bool availibilty)
        {
            rIsAvailable = availibilty;
        }
       

       

        
    }
}
