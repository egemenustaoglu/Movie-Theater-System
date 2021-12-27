using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from User.cs
    // is-a relationship *Inheritance of (Manager) from User class.
    public class Manager : User
    {
        private String name;
        private int id;
        public Manager(String Name , int Id)
        {
            id = Id;
            name = Name;
        }
        public void setName(String Name)
        {
            name = Name;
        }
        public String getName()
        {
            return name;
        }

        //printInfo() is for usage of Polymorphism
        //Override the method for the specific user type.
        public override void printInfo()
        {
            Console.WriteLine("My name is " + getName() + " and I am the Manager");
        }
        
    }
}
