using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // The class being inherited from.
    // Base class of ImaxTheater & RegularTheater.
    public abstract class Theather
    {
        private  int theatherID;
        private int seatCount;
        private bool isAvailable;

        public Theather()
        {

        }

        public int TheatherID { get => theatherID; }
        public int SeatCount { get => seatCount;  }
        public bool IsAvailable { get => isAvailable; }

        public abstract int getID();
        public abstract int getSeat();

        public abstract void setID(int index);
        public abstract void setSeat(int index);


        //isTheaterAvaliable() method for further usage of Polymorphism in child classes.
        public abstract bool isTheaterAvaliable();
    }
}
