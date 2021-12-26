using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    class ImaxTheather : Theather
    {
        private int imaxTheatherID;
        private int imaxSeatCount;
        private bool imaxIsAvailable;
        Movie movie = new Movie();


        public ImaxTheather(int IMAXTheatherID, int IMAXSeatCount , bool ImaxIsAvailable , Movie Movie)
        {
            imaxTheatherID = IMAXTheatherID;
            imaxSeatCount = IMAXSeatCount;
            imaxIsAvailable = ImaxIsAvailable;
            movie = Movie;
        }
        // get methods
        public override int getID()
        {
            return imaxTheatherID;
        }

        public override int getSeat()
        {
            return imaxSeatCount;
        }
        public string getMovie()
        {
            //call movie title from Moive class's getMovieTitle method which return string
            return movie.getMovieTitle();
        }
        public override bool isThatherAvailable()
        {
            return imaxIsAvailable;
        }
        // set methods
        public override void setID(int index)
        {
            if (index >= 1)
            {
                imaxTheatherID = index;
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
                imaxSeatCount = index;
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
            imaxIsAvailable = availibilty;
        }
       

       

       
    }
}
