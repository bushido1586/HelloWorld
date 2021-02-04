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

        //constrcutor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        } 

        //member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }

    }
}
