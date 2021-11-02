using System;

namespace OperatorsC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);  


            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0; 
            }

            if(numTemp < 40)
                {
                    Console.WriteLine("Take the coat");
                } else if(numTemp == 60)
                {
                    Console.WriteLine("Pants and pull over will be fine");
                } else if(numTemp > 90){
                    Console.WriteLine("It's super hot!");
                } else
                {
                    
                    Console.WriteLine("Invalid entry");
                }
        }
    }
}