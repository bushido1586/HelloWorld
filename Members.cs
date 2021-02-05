using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public field
        public int age;

        //property=members exposes jobTitle safely
        public string JobTitle { get; set; } //-or-

        /* public string JobTitle{
         get{
        return jobTitle;
        }
        set{
        jobTitle=value;
        }
        } */

        // Method -member
         public void Introduction(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }else
            {
                Console.WriteLine("Hi, my name is {0}, and my Job is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is " + salary);
        }

        // member -constructor

        public Members()
        {
            age = 30;
            memberName = "lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member finalizer-destructor
        ~Members()
        {
            // cleanup statemens
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Deconstruction of Members object");
        }

    }
}
