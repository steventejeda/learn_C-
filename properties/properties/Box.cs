using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
     class Box
    {
        //member varibles
        private int length;
        private int height;
        private int width;
        public int volume;

        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        } 

        public int Width { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }

        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;

        }
        
        public void DisplayInfo()
        {
            volume = length * width * height;
            Console.WriteLine($"length is {length}, height is {height}, and width is {width} so the volume is {volume}");
        }
    }
}
