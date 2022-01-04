using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from User.cs
    // is-a relationship *Inheritance of (Ticket Officer) from User class.
    class TicketOfficer : User
    { 
        private int id;
        public TicketOfficer()
        {

        }
        public TicketOfficer(String Name , int Age) :base (Name , Age)
        {
            id = generalStaffId;
            generalStaffId += 1;
        }
        // get methods
        public int GetId()
        {
            return id;
        }
        //printInfo() is for usage of Polymorphism
        //Override the method for the specific user type.
        public override void PrintInfo()
        {
            Console.WriteLine("Ticket officer's name is : " + GetName() + "\n" +
                "Ticket officer's id is : " + GetId());
        }

        public static void createNewTicketOfiifcer()
        {
            try
            {
                Console.WriteLine(System.indent + "*** Creating new Ticket Officer***\n" +
               "Please enter full name of the Ticket Officer");
                String newTicketofficerName = Console.ReadLine(); ;
                Console.WriteLine("Please enter the age of the ticket officer");
                int newTicketOfficerAge = Convert.ToInt32(Console.ReadLine());
                if (newTicketOfficerAge < 18)
                {
                    throw new UserException("Your Ticket Officer's age can not be lower than 18");
                }
                TicketOfficer newTicketOfficer = new TicketOfficer(newTicketofficerName, newTicketOfficerAge);
                System.ticketOfficerList.Add(newTicketOfficer);               
            }
            catch(UserException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }


        }
    }
}