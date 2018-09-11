using System;

namespace dotnetdayone
{
    class Program
    {
        static void Prompt()
        {
            System.Console.WriteLine($"Choose a number from 1 to 100");
        }

        static int Pick()
        {
            var userInput = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Your choice is {userInput}");
            return userInput;
        }

        static int CGuess()
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 100);
            System.Console.WriteLine($"My guess was going to be {randomNumber}");
            return randomNumber;
        }

        static void Main(string[] args)
        {
            Prompt();
            Pick();
            CGuess();
        }
    }
}