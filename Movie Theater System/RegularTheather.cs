﻿using System;
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
            if(index >= 1)
            {
                rTheatherID = index;
            }
            else
            {
                Console.WriteLine("You should enter above 0 "); ;
            }
        }

        public override void SetSeat(int index)
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
        public void SetMovie(Movie movie)
        {
            this.movie = movie;
        }

        //SANKI BU METOD BURDA OLMAMALI
        public void SetImaxIsAvailable(bool availibilty)
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
