﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // The class being inherited from.
    // Base class of ImaxTheater & RegularTheater.
    public abstract class TheatherSaloon
    {
        private  int theatherID;
        private int seatCount;
        private bool isAvailable;

        public int TheatherID { get => theatherID; set => theatherID = value; }
        public int SeatCount { get => seatCount; set => seatCount = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public TheatherSaloon(int theatherID , int seatCount , bool isAvailable)
        {
            try
            {
                if (theatherID >= 0)
                {
                    this.TheatherID = theatherID;
                }
                else
                {
                    throw new SaloonException("You should enter ID above or equal the '0' ");
                }
                if(seatCount > 0)
                {
                    this.SeatCount = seatCount;
                }
                else
                {
                    throw new SaloonException("You should enter seat number above  the '0' ");
                }
                this.IsAvailable = isAvailable;
            }
            catch(SaloonException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            
        }
        // get methods 
        public int GetID()
        {
            return theatherID;
        }
        public int GetSeat()
        {
            return seatCount;
        }
        // set methods 
        public void SetID(int index)
        {
            try
            {
                if (index >= 1)
                {
                    theatherID = index;
                }
                else
                {
                    throw new SaloonException("You should enter ID above or equal the '0' ");
                }
            }
            catch (SaloonException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
        public void SetSeat(int index)
        {
            try
            {
                if (index >= 1)
                {
                    seatCount = index;
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
        //MakeGeneralDiscount() method for further usage of Polymorphism in child classes.
//Bu methot abstract diğer 2 theather child ında override edip ikisine farklı indirim miktarları giricen daha sonra system da makedisc methoduna TheatherSaloon objesi alıcan --> System.cs --> 31
        public abstract void MakeGeneralDiscount();
    }
    public class SaloonException : Exception
    {
        public SaloonException(string Message) : base(Message)
        {

        }
    }

}
