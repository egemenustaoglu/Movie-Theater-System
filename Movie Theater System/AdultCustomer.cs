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
        private Double Balance;
        public AdultCustomer(String Name, int Age,Double Balance) : base(Name, Age,Balance)
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