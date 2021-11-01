using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine("Starting the game");
            AskForUserName();
        }

        static void AskForUserName()
        {
            Console.WriteLine("Asking for user for name....");
        }

        private static void PlayGame()
        {
            Console.WriteLine("Playing the game...");
            DisplayMaskedWord();
            AskForLetter();
        }

        static void DisplayMaskedWord()
        {
            Console.WriteLine("Displays masked word...");
        }

        static void AskForLetter()
        {
            Console.WriteLine("Asking for Letter...");
        }

        private static void EndGame()
        {
            Console.WriteLine("");
        }
    }
}
