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

            if (isRegistered)
            {
                Console.WriteLine("Hi there, regsitered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, "+userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hello Admin");
                    }
                }
            }

        }
        
    }
}