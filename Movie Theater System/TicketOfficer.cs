﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    // Derived class from User.cs
    // is-a relationship *Inheritance of (Ticket Officer) from User class.
    class TicketOfficer : User
    { 
        private int id;
        private bool makeChildDiscount = false;
        private bool makeStudentDiscount = false;
        private bool makeAdultDiscount = false;
        public TicketOfficer()
        {

        }
        public TicketOfficer(String Name , int Age) :base (Name , Age)
        {
            id = generalStaffId;
            generalStaffId += 1;
        }
        // get methods
        public int GetId()
        {
            return id;
        }
        //printInfo() is for usage of Polymorphism
        //Override the method for the specific user type.
        public override void PrintInfo()
        {
            Console.WriteLine("Ticket officer's name is : " + GetName() + "\n" +
                "Ticket officer's id is : " + GetId());
        }
        public static void TicketOfficerPanel()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(System.indent + "*** Ticket Officet Panel ***\n" +
                "Press 1 to diplay Movies\n" +
                "Press 2 to create new Customer");
                int index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Movie.ListMovies();
                        break;
                    case 2:
                        CreateNewCustomer();
                        break;
                }
            }

        }

        public static void CreateNewCustomer()
        {
            try 
            {
                Console.WriteLine("Give a name to customer ...");
                string newCustomerName = Console.ReadLine();
                Console.WriteLine("Give an age to customer ...");
                int newCustomerAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give a balance to customer ...");
                double newCustomerBalance = Convert.ToDouble(Console.ReadLine());
                string newCustomerPassword = Customer.EnterYourOwnPassword();
                if (newCustomerAge <= 12 && newCustomerAge >= 0)
                {
                    Customer childCustomer = new ChildCustomer(newCustomerName, newCustomerAge, newCustomerBalance);
                    childCustomer.SetPassword(newCustomerPassword);
                    System.customerList.Add(childCustomer);
                }
                else if (newCustomerAge > 12)
                {
                    Console.WriteLine("Is customer a student 'T' or 'F'");
                    string newCustomerIsStudent = Console.ReadLine();
                    if (newCustomerIsStudent == "T" || newCustomerIsStudent == "t")
                    {
                        Customer studentCustomer = new StudentCustomer(newCustomerName, newCustomerAge, newCustomerBalance);
                        studentCustomer.SetPassword(newCustomerPassword);
                        System.customerList.Add(studentCustomer);

                    }
                    else if (newCustomerIsStudent == "F" || newCustomerIsStudent == "f")
                    {
                        Customer adultCustomer = new AdultCustomer(newCustomerName, newCustomerAge, newCustomerBalance);
                        adultCustomer.SetPassword(newCustomerPassword);
                        System.customerList.Add(adultCustomer);
                    }
                }
                else
                {
                    throw new UserException("Your age must be 0 or more");
                }
            }
            catch (UserException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
        public static void CreateNewTicketOfiifcer()
        {
            try
            {
                Console.WriteLine(System.indent + "*** Creating new Ticket Officer***\n" +
               "Please enter full name of the Ticket Officer");
                String newTicketofficerName = Console.ReadLine(); ;
                Console.WriteLine("Please enter the age of the ticket officer");
                int newTicketOfficerAge = Convert.ToInt32(Console.ReadLine());
                if (newTicketOfficerAge < 18)
                {
                    throw new UserException("Your Ticket Officer's age can not be lower than 18");
                }
                TicketOfficer newTicketOfficer = new TicketOfficer(newTicketofficerName, newTicketOfficerAge);
                System.ticketOfficerList.Add(newTicketOfficer);               
            }
            catch(UserException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }


        }
        public static void ChangeTicketOfficer()
        {
            Console.WriteLine(System.indent + "***Ticket Officer List***");
            int ticketOfficerCount = 1;
            foreach(TicketOfficer ticketOfficer in System.ticketOfficerList)
            {                
                Console.WriteLine(ticketOfficerCount + ". Movie's informations are \n" +
                     "ID of the Ticket Officer : " + ticketOfficer.GetId() + "\n" +
                     "Name of the TicketOfficer : " + ticketOfficer.GetName() + "\n" +
                     "Age of the TicketOfficer  : " + ticketOfficer.GetAge());
                ticketOfficerCount += 1;
            }
            try
            {
                Console.WriteLine("Select which Ticket Officer will you be modify");
                int ticketOfficerNumber = Convert.ToInt32(Console.ReadLine());
                if (ticketOfficerNumber < 0)
                {
                    throw new SaloonException("Your selection should be in the list");
                }
                TicketOfficer changedTicketOfficer = System.ticketOfficerList[ticketOfficerNumber - 1];
                Console.WriteLine(System.indent + "***Changing Information***");
                Console.WriteLine("Enter new Name for your Ticket Officer");
                String newTicketOfficerName = Console.ReadLine();
                if (newTicketOfficerName == null)
                {
                    throw new SaloonException("Your new Name can not be empty");
                }
                Console.WriteLine("Enter new Age for your Ticket Officer");
                int newTicketOfficerAge = Convert.ToInt32(Console.ReadLine());
                if (newTicketOfficerAge < 18)
                {
                    throw new SaloonException("Your new Age should be 18 or more");
                }
                changedTicketOfficer.SetName(newTicketOfficerName);
                changedTicketOfficer.SetAge(newTicketOfficerAge);
            }
            catch (SaloonException e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }

        }
        
    }
}