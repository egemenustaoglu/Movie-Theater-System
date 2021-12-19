using System;

namespace Movie_Theater_System
{
    class System
    {
        static void Main(string[] args)
        {
            
            User user1 = new Manager("Atakan", 1);
            User user2 = new TicketOfficer("Egoş", 2);
            Asd(user1);
            Asd(user2);
        }

        //Here we create a method for show polymorphism 
        public static void Asd(User user)
        {
            user.userWorking();
        }
    }
}
