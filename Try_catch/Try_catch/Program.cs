using System;

namespace TryAndCatchC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            
            try
            {
                int userInputAsInt = int.Parse(userInput);
                Console.WriteLine($"The number you entered is {userInputAsInt}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: The number you entered was too long");
            }
            finally
            {
                Console.WriteLine("Success!");
            }



        }
    }
}