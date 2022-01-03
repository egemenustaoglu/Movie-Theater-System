using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from Customer.cs
    // is-a relationship *Inheritance of (Student Customer) from Customer class.
    class StudentCustomer : Customer
    {
        private int age;
        private string fullName;
        public StudentCustomer(String Name , int Age) : base(Name , Age)
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