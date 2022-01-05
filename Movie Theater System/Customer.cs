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
            return Balance;
        }
        //set methods
        public void SetBalance(double newBalance)
        {
            Balance = newBalance;
        }
        public void AddMoneyToBalance()
        {
            Console.WriteLine("Your current account balance is : " + GetBalance() + "\n" +
                            "How much do you want to add to your account : ");
            double addingToBalance = Convert.ToDouble(Console.ReadLine());
            SetBalance(GetBalance() + addingToBalance);
            Console.WriteLine("Your Final balance is : " + GetBalance());
        }
        
        public static void RequestSchedual() 
        {
            Movie.ListMovies();
        }
        public void RequestTicket()
        {
            Movie.ListMovies();
            Console.WriteLine(System.indent + "Select a movie for buy ticket");
            int choice = Convert.ToInt32(Console.ReadLine());
            Movie aMovie = System.movieList[choice - 1];
            MakeDiscount(aMovie);
        }
        public abstract void MakeDiscount(Movie mov);
        public abstract void CustomerPanel();
        public override void PrintInfo()
        {
        }
    }
}