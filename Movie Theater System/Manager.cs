using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
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

        //userWorking() for usage of Polymorphism we override the method for the specific user type
        public override void userWorking()
        {
            Console.WriteLine("My name is " + name + " and I am a manager");
        }
        
    }
}
