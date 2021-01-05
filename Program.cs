using System;

namespace HelloWorld
{

    class Program
    {
        
        static void Main(string[] args)
        {
            WriteSomething();
            WriteMessage("I am an argument and am called from a method");

        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteMessage(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}