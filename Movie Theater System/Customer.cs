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

        public int Age { get => age; set => age = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public Customer( string Name , int Age ) : base(Name ,Age)
        {
            this.Age = Age;
            FullName = Name;
        }

        public abstract void RequestTicket();
        public abstract void RequestSchedual();
        public void Pay() 
        { 

        }
        public override void PrintInfo()
        {
        }
    }
}