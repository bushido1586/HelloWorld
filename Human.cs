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
        public string eyeColor;
        public int age;

        //constrcutor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        } 

        //member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes and I'm {3} years old.", firstName, lastName, eyeColor, age);
        }

    }
}
