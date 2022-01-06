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
        private string password;

        public int Age { get => age; set => age = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Password { get => password; set => password = value; }

        public Customer( string Name , int Age ,double Balance) : base(Name ,Age)
        {
            this.Age = Age;
            FullName = Name;
            balance = Balance;
        }

        //get methods
        public string GetPassword()
        {
            return password;
        }
        public double GetBalance()
        {
            return Balance;
        }
        //set methods
        public void SetPassword(String password)
        {
            this.password = password;
        }
        public void SetBalance(double newBalance)
        {
            try
            {
                if (newBalance < 0)
                {
                    throw new UserException("Your balance can not be below 0");
                }
                else
                {
                    balance = newBalance;
                }
            }catch(UserException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
           
        }
        public void AddMoneyToBalance()
        {
            try
            {
                Console.WriteLine("Your current account balance is : " + GetBalance() + "\n" +
                            "How much do you want to add to your account : ");
                double addingToBalance = Convert.ToDouble(Console.ReadLine());
                if(addingToBalance < 0)
                {
                    throw new UserException("You can not add a minus amount to your account");
                }
                SetBalance(GetBalance() + addingToBalance);
                Console.WriteLine("Your Final balance is : " + GetBalance());
            }
            catch (UserException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            
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
            try
            {
                if(choice > System.movieList.Count + 1)
                {
                    throw new UserException("You should select a valid input");
                }
                Movie aMovie = System.movieList[choice - 1];
                MakeDiscount(aMovie);
            }
            catch(UserException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
           
        }
        public abstract void MakeDiscount(Movie mov);
        public abstract void CustomerPanel();
        public override void PrintInfo()
        {
            Console.WriteLine("Name " + GetName());
            Console.WriteLine("Age " + GetAge());
            Console.WriteLine("Balance " + GetBalance());
        }
        public static string EnterYourOwnPassword()
        {
            Console.WriteLine("*** Please set a new password for enterence to Movie Theather System***");
            string password = Console.ReadLine();
            return password;
        }
    }
}