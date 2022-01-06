using System;
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
        private static int movieListCounter;

        public int TheatherID { get => theatherID; set => theatherID = value; }
        public int SeatCount { get => seatCount; set => seatCount = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
        public TheatherSaloon()
        {

        }
        public TheatherSaloon(int theatherID , int seatCount , bool isAvailable )
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
        public bool GetIsAvailable()
        {
            return isAvailable;
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
        public void SetIsAvailable(bool change)
        {
            isAvailable = change;
        }
     
        public static void CreateTheatherSaloons()
        {
            TheatherSaloon saloon1 = new ImaxTheatherSaloon(1, 50, true);
            TheatherSaloon saloon2 = new RegularTheatherSaloon(2, 75, true);
            TheatherSaloon saloon3 = new ImaxTheatherSaloon(3, 34, false);
            TheatherSaloon saloon4 = new ImaxTheatherSaloon(4, 45, true);
            TheatherSaloon saloon5 = new RegularTheatherSaloon(5, 100, false);
            System.theatherSaloonList.Add(saloon1);
            System.theatherSaloonList.Add(saloon2);
            System.theatherSaloonList.Add(saloon3);
            System.theatherSaloonList.Add(saloon4);
            System.theatherSaloonList.Add(saloon5);
        }

        //MakeGeneralDiscount() method for further usage of Polymorphism in child classes.
        // child classes must override this method because it is abstract method and we can specify this method's discount amount depending to which theather saloon is it . --> System.cs --> 31
        //public abstract void MakeFixedDiscount();

        public static void ChangeSaloonInformation()
        {
            int SalooCounter = 1;
            Console.WriteLine(System.indent + "***Theather Saloon List***");
            foreach (TheatherSaloon theatherSaloon in System.theatherSaloonList)
            {
                Console.WriteLine(SalooCounter + ". Saloon's informations are \n" +
                     "ID of the Saloon : " + theatherSaloon.GetID() + "\n" +
                     "Seat Count of the Saloon : " + theatherSaloon.GetSeat());
                SalooCounter += 1;
            }
            try
            {
                Console.WriteLine("Select which Theather Saloon will you be modify");
                int saloonNumber = Convert.ToInt32(Console.ReadLine());
                if (saloonNumber < 0)
                {
                    throw new SaloonException("Your selection should be in the list");
                }
                TheatherSaloon changedTheatherSaloon = System.theatherSaloonList[saloonNumber-1];
                Console.WriteLine(System.indent+"***Changing Information***");
                Console.WriteLine("Enter new id for your Saloon");
                int newSaloonID = Convert.ToInt32(Console.ReadLine());
                if (newSaloonID < 0)
                {
                    throw new SaloonException("Your new ID should be 0 or more");
                }
                Console.WriteLine("Enter new seat count for your Saloon");
                int newSalooSeatCount = Convert.ToInt32(Console.ReadLine());
                if (newSalooSeatCount < 0)
                {
                    throw new SaloonException("Your new Seat Count should be 0 or more");
                }
                changedTheatherSaloon.SetID(newSaloonID);
                changedTheatherSaloon.SetSeat(newSalooSeatCount);
            }
            catch(SaloonException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }

        public static TheatherSaloon DisplayAvailableTheatherSaloons()
        {
            Console.WriteLine(System.indent + "*** Listing available Movie Theathers ***");
            movieListCounter = 1 ;
            foreach(TheatherSaloon saloon in System.theatherSaloonList)
            {
                if(saloon.GetIsAvailable() == true)
                {
                    Console.WriteLine(movieListCounter + ". Available saloon is : " + saloon.GetID() + "\n" +
                        "And its seat count is : " + saloon.GetSeat()) ;
                }
                movieListCounter += 1;
            }
            Console.WriteLine("Which theather saloon you will be select to shown the new movie. Please give the ID of saloon");
            int saloonID = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (TheatherSaloon sal in System.theatherSaloonList)
                {
                    if (sal.GetID().Equals(saloonID))
                    {
                        return sal;
                    }
                }
                throw new SaloonException("You entered a wrong ID");
            }
            catch(SaloonException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            return null;
        }
    }
    // To throw exceprtion we create our exception class which is inherit from Exception generic class and we use it to display our error message.
    public class SaloonException : Exception
    {
        public SaloonException(string Message) : base(Message)
        {

        }
    }

}
