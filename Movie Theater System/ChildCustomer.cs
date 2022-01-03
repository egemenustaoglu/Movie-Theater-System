using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Customer.cs
    // is-a relationship *Inheritance of (Child Customer) from Customer class.
    class ChildCustomer : Customer
    {
        private int age;
        private string Name;
        public ChildCustomer(String Name, int Age) : base(Name, Age)
        {
        }


        public override void Pay()
        {

        }
        public override void RequestSchedual()
        {

        }
        public override void RequestTicket()
        {

        }
        public override void PrintInfo()
        {

        }
    }
}