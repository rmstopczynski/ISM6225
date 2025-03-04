using System;

namespace Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I have guessed a number, can you tell me what it is?");

            Random random = new Random();
            int targetNumber = random.Next(1, 11); // Random number between 1 and 10

            bool found = false;
            int userGuessNum = 0;

            while (!found)
            {
                // Read user input
                string userGuessInput = Console.ReadLine();

                // Validate and convert input to integer
                if (int.TryParse(userGuessInput, out userGuessNum))
                {
                    if (userGuessNum > targetNumber)
                    {
                        Console.WriteLine("Too High!");
                    }
                    else if (userGuessNum < targetNumber)
                    {
                        Console.WriteLine("Too Low!");
                    }
                    else
                    {
                        Console.WriteLine("Awesome! You guessed the number correctly!");
                        found = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
