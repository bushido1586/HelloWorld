using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            //create object of class (same as java)/ Instance of Human
            Human Brad = new Human("Brad", "Reed", "blue", 34);
            Brad.Introduction();

            Human kristin = new Human("Kristin", "Kiro", "brown", 33);
            kristin.Introduction();

            Human basicHuman = new Human();
            basicHuman.Introduction();

            Human basicHuman2 = new Human("dave", "smith", "green");
            basicHuman2.Introduction();

            Human natalie = new Human("Natalie");
            natalie.Introduction();

            Human michael = new Human("Michael", "Miller");
            michael.Introduction();

            Human frank = new Human("Frank", "Walter", 40);
            frank.Introduction();
        }
        
    }
}