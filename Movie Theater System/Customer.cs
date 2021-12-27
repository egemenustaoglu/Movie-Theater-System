using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // The class being inherited from.
    // Base class of AdultCustomer, ChildCustomer & StudentCustomer. 
    abstract class Customer : User
    {
        private int age;
        private string fullName;


        public Customer(int Age , string FullName)
        {
            age = Age;
            fullName = FullName;
        }

        public abstract void requestTicket();
        public abstract void requestSchedual();
        public abstract void pay();
        public override void printInfo()
        {
        }
    }
}