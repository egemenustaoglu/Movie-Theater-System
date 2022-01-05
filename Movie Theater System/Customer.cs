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
        private double balance;

        public int Age { get => age; set => age = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public double Balance { get => balance; set => balance = value; }

        public Customer( string Name , int Age ,double Balance) : base(Name ,Age)
        {
            this.Age = Age;
            FullName = Name;
            balance = Balance;
        }
        //get methods
        public double GetBalance()
        {
            return balance;
        }
        //set methods
        public void SetBalance(double newBalance)
        {
            balance = newBalance;
        }
        public abstract void RequestTicket();
        public abstract void RequestSchedual();
        public void Pay() 
        {
            TicketOfficer.TakePayment((Customer)this.MemberwiseClone());
        }
        public override void PrintInfo()
        {
        }
    }
}