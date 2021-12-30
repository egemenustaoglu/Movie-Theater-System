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

        public abstract void RequestTicket();
        public abstract void RequestSchedual();
        public abstract void Pay();
        public override void PrintInfo()
        {
        }
    }
}