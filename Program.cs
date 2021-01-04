using System;

namespace HelloWorld
{
    //Constants/Immutable values which cannot be changed for life of program. 

    class Program
    {
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        const string myBirthday = "11.13.1986";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", myBirthday);
        
        }
    }
}