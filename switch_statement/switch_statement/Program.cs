namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
        //Create an instance of my class
        Human steven = new Human();
            //New instance 
            steven.firstName = "Steven";

            steven.IntroduceMyself();

            Console.Read();     
        }
    }
}