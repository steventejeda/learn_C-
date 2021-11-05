using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class
{
    class Box
    {
        //Member variable
        public int length;
        public int width;
        public int height;
        public int volume;

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
            
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }

        public void DisplayInfo()
        {
            volume = length * width * height;
            System.Console.Write($"The length is {length}, the width is {width}, the height is {height}, so the total volume is {volume}");
        }
    }
}