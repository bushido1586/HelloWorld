using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            //create object of class (same as java)/ Instance of Human
            Human Brad = new Human();
            Brad.firstName = "Brad";
            Brad.Introduction();

            Human michael = new Human();
            michael.firstName = "Mikel";
            michael.Introduction();
            
        }
        
    }
}