namespace Class
{
    class Program
    {
       static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(6);
            box.width = 4;
            box.height = 5;

            box.DisplayInfo();
            Console.Read();
        }
    }
}