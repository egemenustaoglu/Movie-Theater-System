using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Theater.cs
    // is-a relationship *Inheritance of (Imax Theater) from Theater class.
    class ImaxTheatherSaloon : TheatherSaloon
    {
        private int imaxTheatherID;
        private int imaxSeatCount;
        private bool imaxIsAvailable;
        // has-a relationship ImaxTheather has a movie inside
        Movie movie = new Movie();


        public ImaxTheatherSaloon(int IMAXTheatherID, int IMAXSeatCount , bool ImaxIsAvailable , Movie Movie) : base(IMAXTheatherID, IMAXSeatCount, ImaxIsAvailable)
        {
            movie = Movie;
        }
        // get methods
        
        public string getMovie()
        {
            //call movie title from Moive class's getMovieTitle method which return string
            return movie.GetMovieTitle();
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
        public override void MakeGeneralDiscount()
        {

        }


    }
   
}
