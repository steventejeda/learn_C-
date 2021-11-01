namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter a string here: ");
            input = Console.ReadLine();

            Console.WriteLine("Enter the character to search: ");
            string inputIndex = Console.ReadLine();

            Console.WriteLine(input.IndexOf(inputIndex));

        }
    }
}