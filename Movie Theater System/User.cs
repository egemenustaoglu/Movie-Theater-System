using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // The class being inherited from.
    // Base class of Manager & Ticket officer.
    public abstract class User
    {

        public User()
        {
        
        }

        //printInfo() method for further usage of Polymorphism in child classes.
        public abstract void printInfo();
    }
}