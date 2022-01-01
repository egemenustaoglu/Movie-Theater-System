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
        public override int GetID()
        {
            return rTheatherID;
        }

        public override int GetSeat()
        {
            return rSeatCount;
        }
        public string GetMovie()
        {
            return movie.GetMovieTitle();
        }
        // set methods
        public override void SetID(int index)
        {
            try
            {
                if(index >= 1)
                    {
                        rTheatherID = index;
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
                    rSeatCount = index;
                }
                else
                {
                    throw new SaloonException("You should enter seat number above the '0' ");
                }
            }
            catch (SaloonException e)
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
        //SANKI BU METOD BURDA OLMAMALI
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
