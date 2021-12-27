﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Theater.cs
    // is-a relationship *Inheritance of (Imax Theater) from Theater class.
    class ImaxTheather : Theather
    {
        private int imaxTheatherID;
        private int imaxSeatCount;
        private bool imaxIsAvailable;
        // has-a relationship ImaxTheather has a movie inside
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


        //isTheaterAvaliable() is for usage of Polymorphism
        //Override the method for the specific theater condition.
        public override bool isTheaterAvaliable()
        {
            return imaxIsAvailable;
        }


    }
}