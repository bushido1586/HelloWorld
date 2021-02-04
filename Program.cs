using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);

            Console.WriteLine("box1 volume is " + box.Volume);
            box.Width = 10;
            Console.WriteLine("Box volume is " + box.Volume);
            box.DisplayInfo();

            Console.WriteLine("Front Surfcae is " + box.FrontSurcae);
            
        }
        
    }
}