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
        public override int GetID()
        {
            return imaxTheatherID;
        }

        public override int GetSeat()
        {
            return imaxSeatCount;
        }
        public string getMovie()
        {
            //call movie title from Moive class's getMovieTitle method which return string
            return movie.GetMovieTitle();
        }
        
        // set methods
        public override void SetID(int index)
        {
            try
            {
                if (index > 0 )
                {
                    imaxTheatherID = index;
                }
                else
                {
                    throw new SaloonException("You should enter ID above or equal the '0' ");
                }
            }
            catch(SaloonException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }

        public override void SetSeat(int index)
        {
            try
            {
                if (index >= 1)
                {
                    imaxSeatCount = index;
                }
                else
                {
                    throw new SaloonException("You should enter seat number above the '0' ");
                }
            }
            catch(SaloonException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
           
        }
        public void SetMovie(Movie movie)
        {
            this.movie = movie;
        }
        public void SetImaxIsAvailable(bool availibilty)
        {
            imaxIsAvailable = availibilty;
        }


        //isTheaterAvaliable() is for usage of Polymorphism
        //Override the method for the specific theater condition.
        public override bool IsTheaterAvaliable()
        {
            return imaxIsAvailable;
        }


    }
   
}
