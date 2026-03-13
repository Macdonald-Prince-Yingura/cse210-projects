using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added successfully.");
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("Journal saved successfully.");
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine("Journal loaded successfully.");
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}

/*
EXCEEDING REQUIREMENTS:
This program includes an additional feature that calculates and displays
the word count of each journal entry when displayed. This helps users
reflect on how detailed their entries are and encourages more writing.
*/