using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        //member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm {0}", firstName + " " + lastName);
        }

    }
}
