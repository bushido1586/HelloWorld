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

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called; object created");
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;            
        }

        public Human(string firstName)
        {
            this.firstName = firstName;         
        }

        // parameterized constrcutor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //member method
        public void Introduction()
        {
            if (age != 0 && lastName !=null && eyeColor != null && firstName !=null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes and I'm {3} years old.", firstName, lastName, eyeColor, age);
            }else if(age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. and I'm {2} years old.", firstName, lastName, age);
            }
            
            else if(lastName != null && eyeColor != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes.", firstName, lastName, eyeColor);

            }else if(lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if(firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}.", firstName);
            }else
            {
                Console.WriteLine("parameters not met");
            }
        }

    }
}
