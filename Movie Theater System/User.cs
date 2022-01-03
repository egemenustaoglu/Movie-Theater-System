using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // The class being inherited from.
    // Base class of Manager & Ticket officer.
    public abstract class User
    {
        private String name;
        public User(String Name)
        {
            name = Name;
        }
       
        // get methods
        public String GetName()
        {
            return name;
        }
        // set methods
        public void SetName(String Name)
        {
            name = Name;
        }
        //printInfo() method for further usage of Polymorphism in child classes.
        public abstract void PrintInfo();
    }
}