using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            //create object of class (same as java)/ Instance of Human
            Human Brad = new Human("Brad", "Reed");
            Brad.Introduction();

            Human kristin = new Human("Kristin", "Kiro");
            kristin.Introduction();           
        }
        
    }
}