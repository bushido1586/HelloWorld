using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Brad";
            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();


            Console.WriteLine(capsMessage);
            Console.Read();

        }
    }
}