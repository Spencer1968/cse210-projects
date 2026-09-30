using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string keepPlaying = "yes";

        // Outer loop: Runs every time the user wants to play a new game
        while (keepPlaying.ToLower() == "yes")
        {
            // Reset game variables at the start of every new round
            int magicNumber = randomGenerator.Next(1, 101);
            int numGuesses = 0;
            int guess = -1;

            // Inner loop: Keeps asking for guesses until the user gets it right
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed the number in {numGuesses} guesses!");
                }
            }

            // Only ask to play again AFTER the current game is finished
            Console.Write("Would you like to play again? (Yes/No) ");
            keepPlaying = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}