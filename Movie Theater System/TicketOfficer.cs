using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from User.cs
    // is-a relationship *Inheritance of (Ticket Officer) from User class.
    class TicketOfficer : User
    {
        private String name;
        private int id;
        public TicketOfficer(String Name, int Id) 
        {
            id = Id;
            name = Name;
        }
        public  void SetName(String Name)
        {
            name = Name;
        }
        public String GetName()
        {
            return name;
        }

        //printInfo() is for usage of Polymorphism
        //Override the method for the specific user type.
        public override void PrintInfo()
        {
            Console.WriteLine("My name is " + GetName() + " and I am a Ticket Officer");
        }
    }
}