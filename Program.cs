using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your usernname: ");
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            userName = Console.ReadLine();

            if (isRegistered && userName !="" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, regsitered user");
               
                Console.WriteLine("Hi there, "+userName);
                   
                Console.WriteLine("Hello Admin");
                
            }

            if ( isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

        }
        
    }
}