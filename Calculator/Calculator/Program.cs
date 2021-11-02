using System;

class Calculator
{

    static void Main(String[] args)
    {
        Multiply();
        Console.Read();

    }

    public static void Add()
    {
        Console.WriteLine("Enter first number here...");
        string firstInput = Console.ReadLine();
        Console.WriteLine("Enter second input here...");
        string secondInput = Console.ReadLine();

        int num1 = int.Parse(firstInput);
        int num2 = int.Parse(secondInput);

        int result = num1 + num2;

        Console.WriteLine($"The answer is {result}");
    }

    public static void Multiply()
    {
        Console.WriteLine("Enter first number here...");
        string firstInput = Console.ReadLine();
        Console.WriteLine("Enter second input here...");
        string secondInput = Console.ReadLine();

        int num1 = int.Parse(firstInput);
        int num2 = int.Parse(secondInput);

        int result = num1 * num2;

        Console.WriteLine($"The answer is {result}");


    }

}