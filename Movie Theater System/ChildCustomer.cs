﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Theater_System
{
    class ChildCustomer :Customer
    {
        private int age;
        private string fullName;
        public ChildCustomer() : base(Age, FullName)
        {
        }

        public static int Age { get; }
        public static string FullName { get; }

        public override void pay()
        {

        }
        public override void requestSchedual()
        {

        }
        public override void requestTicket()
        {

        }
        public override void printInfo()
        {

        }
    }
}
