using System;

class Program
{
    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");
        string userInput = "";
        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Prompt the user for a journal entry
                // Generate a random prompt
                // Display the prompt to the user
                // Get the user's response
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("MM/dd/yyyy");

                // Create a new Entry object
                // Set the date, prompt text, and entry text
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                // Add the new entry to the journal
                thejournal.AddEntry(newEntry);
            }
            if (userInput == "2")
            {
                // Display all entries in the journal
                thejournal.DisplayAll();
            }
            if (userInput == "3")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                // Load entries from a file
                thejournal.LoadFromFile(fileName);

            }
            if (userInput == "4")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                // Save entries to a file
                thejournal.SaveToFile(fileName);
            }
            if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }





    }
}