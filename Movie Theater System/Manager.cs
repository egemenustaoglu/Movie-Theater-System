using Movie_Theater_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


    // Derived class from User.cs
    // is-a relationship *Inheritance of (Manager) from User class.
    public class Manager : User
    {
        private String name;
        private int id;
        public Manager(String Name , int Id)
        {
            id = Id;
            name = Name;
        }
        // get methods

        public String GetName()
        {
            return name;
        }
        // set methods
        public void SetName(String Name)
        {
            name = Name;
        }

        public void SetMoviePrice(Movie movie ,double price)
        {
        movie.SetBasePrice(price);
        }

        //printInfo() is for usage of Polymorphism
        //Override the method for the specific user type.
        public override void PrintInfo()
        {
            Console.WriteLine("My name is " + GetName() + " and I am the Manager");
        }

        
        
    }

