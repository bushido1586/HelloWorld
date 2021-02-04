using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.SetLength(4);
            box1.Height = -4;
            box1.Width = 5;

            Console.WriteLine("box1 volume is " + box1.GetVolume());

            box1.DisplayInfo();
        }
        
    }
}