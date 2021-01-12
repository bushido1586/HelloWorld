using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int temp = -5;
            string stateOFMater;
            /*
            if (temp < 0)
            
                stateOFMater = "solid";
            
            else
            
                stateOFMater = "liquid";
            */


            //short form

            temp += 30;

            stateOFMater = temp < 0 ? "solid" : "liquid";
            Console.WriteLine("State of mater is {0}", stateOFMater);

        }


        
    }
}