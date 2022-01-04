using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // The class being inherited from.
    // Base class of Manager & Ticket officer.
    public abstract class User
    {
        private String name;
        private int age;
        // used protected to keep sharing generalId int with childrens but not with other classes
        protected static int generalStaffId = 1 ;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public User()
        {

        }

        public User(String Name , int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
       
        // get methods
        public String GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        // set methods
        public void SetName(String Name)
        {
            this.Name = Name;
        }
        public void SetAge(int Age)
        {
            try
            {
                if(Age > 0)
                {
                    this.Age = Age;
                }
                else
                {
                    throw new UserException("Your life couldn't be less than 0 ");
                }
            }
            catch (UserException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
        //printInfo() method for further usage of Polymorphism in child classes.
        public abstract void PrintInfo();
    }
    public class UserException : Exception
    {
        public UserException(String message) : base(message)
        {

        }
    }
}