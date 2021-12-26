using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    //Inheritance parent
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

        public abstract bool isThatherAvailable();
        public abstract void setID(int index);
        public abstract int getID();
        public abstract void setSeat(int index);
        public abstract int getSeat();

    }
}
