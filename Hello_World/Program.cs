using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;

            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " equals " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("D1 divided by D12 is: " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
        }
    }
}
