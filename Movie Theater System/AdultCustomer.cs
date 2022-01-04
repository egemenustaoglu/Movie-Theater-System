using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Customer.cs
    // is-a relationship *Inheritance of (Adult Customer) from Customer class.
    class AdultCustomer : Customer
    {
        private int age;
        private string Name;
        public AdultCustomer(String Name, int Age) : base(Name, Age)
        {
           
        }


       
        public override void RequestSchedual()
        {
            
        }
        public override void RequestTicket()
        {
            
        }
    }
}