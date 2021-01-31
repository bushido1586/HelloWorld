using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
           string wholeText = "";
            int lengthText = 0;

            do
            {
                Console.WriteLine("please enter name of a friend");
                string nameOfFriend = Console.ReadLine();

                int currentLength = nameOfFriend.Length;
                lengthText += currentLength;
                wholeText += nameOfFriend;

            } while (lengthText < 20);
                Console.WriteLine("thanks that was enough!" +wholeText); 

        }


        
    }
}