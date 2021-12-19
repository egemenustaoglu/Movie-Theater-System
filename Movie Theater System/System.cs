using System;

namespace Movie_Theater_System
{
    class System
    {
        static void Main(string[] args)
        {
            User Manager = new Manager("Atakan", 1);
            User TicketOfficer = new TicketOfficer("Egemen", 2);
            UserTest(Manager);
            UserTest(TicketOfficer);
        }

        //Here we create a method for show polymorphism 
        public static void UserTest(User user)
        {
            user.userWorking();
        }
    }
}
