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
       
        public override void CustomerPanel()
        {
            bool flag = false;
            Console.WriteLine("Please enter the Customer's password to continue with Customer panel");
            string enteredPassword = Console.ReadLine();
            if (enteredPassword.Equals(GetPassword()))
            {
                flag = true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You entered wrong password");
                Console.ResetColor();
            }
            while (flag)
            {
                Console.WriteLine(System.indent + "*** Adult Customer Panel ***\n" +
                "Press 1 to Diplay Movies\n" +
                "Press 2 to Request a ticket for a movie\n" +
                "Press 3 to see balance\n" +
                "Press 4 to add money to your balance\n" +
                "Press 5 to Exit customer panel");
                int index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        RequestSchedual();
                        break;
                    case 2:
                        RequestTicket();
                        break;
                    case 3:
                        Console.WriteLine(GetBalance());
                        break;
                    case 4:
                        AddMoneyToBalance();
                        break;
                    case 5:
                        Console.WriteLine("Exiting from Adult Customer panel");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You should enter a valid input");
                        break;
                }
            }
        }
        public override void MakeDiscount(Movie mov)
        {
            double basePrice = mov.GetBasePrice();
            double newBalace = GetBalance() - basePrice;
            this.SetBalance(newBalace);
            Console.WriteLine("Adults have no discount you receipt is : " + basePrice);
        }
    }
}