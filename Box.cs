using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Box
    {
        //member variables
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        //properties

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
            
        }

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box(int length, int height, int width)
        {
            this.length= length;
            this.height=height;
            Width =width;
        }

        public void SetLength(int length)
        {
            if(length <= 0)
            {
                throw new Exception("Length shoould be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int FrontSurcae
        {
            get
            {
                return height * length;
            }

        }

        public void DisplayInfo()
        {
            Console.WriteLine("Legnth is {0}, height is {1}, adn width is {2}. so the volume is {3}", length, height, Width, volume = length*height*Width);
        }

    }
}
