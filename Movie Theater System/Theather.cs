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

        public abstract int GetID();
        public abstract int GetSeat();

        public abstract void SetID(int index);
        public abstract void SetSeat(int index);


        //isTheaterAvaliable() method for further usage of Polymorphism in child classes.
        public abstract bool IsTheaterAvaliable();
    }
}
