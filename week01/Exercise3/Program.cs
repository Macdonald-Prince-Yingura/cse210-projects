using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable to control whether the user wants to keep playing
        string playAgain = "yes";

        // Outer loop to allow the user to play multiple games
        while (playAgain.ToLower() == "yes")
        {
            // Create a random number generator
            Random randomGenerator = new Random();

            // Generate the magic number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);

            // Initialize variables
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have chosen a magic number between 1 and 100.");

            // Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Increase guess counter
                guessCount++;

                // Determine if the guess is too high, too low, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display how many guesses the user made
            Console.WriteLine($"You guessed the number in {guessCount} guesses!");

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();

            Console.WriteLine();
        }

        // Closing message
        Console.WriteLine("Thank you for playing the Guess My Number game!");
    }
}