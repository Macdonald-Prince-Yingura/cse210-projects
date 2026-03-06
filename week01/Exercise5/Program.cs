using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================= Step 1: Display Welcome =================
            DisplayWelcome();

            // ================= Step 2: Prompt User Name =================
            string userName = PromptUserName();

            // ================= Step 3: Prompt User Number =================
            int favoriteNumber = PromptUserNumber();

            // ================= Step 4: Calculate Square =================
            int squaredNumber = SquareNumber(favoriteNumber);

            // ================= Step 5: Display Result =================
            DisplayResult(userName, squaredNumber);
        }

        // ================= Functions =================

        // Displays a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Prompts the user for their name and validates input
        static string PromptUserName()
        {
            string name;
            while (true)
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    return name.Trim();
                }
                else
                {
                    Console.WriteLine("Invalid input. Name cannot be empty.");
                }
            }
        }

        // Prompts the user for their favorite number and validates input
        static int PromptUserNumber()
        {
            int number;
            while (true)
            {
                Console.Write("Please enter your favorite number: ");
                bool isValid = int.TryParse(Console.ReadLine(), out number);

                if (isValid)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }
        }

        // Accepts an integer and returns its square
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Displays the final result
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
}