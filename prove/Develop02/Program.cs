using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Journal myJournal = new Journal();
        Prompt prompts = new Prompt();
        Console.WriteLine("Welcome to the Journal program!");

        // Added an attribute for the user's name for extra personalization. This is for display purposes only.
        Console.WriteLine("Please enter your name.");
        myJournal._name = Console.ReadLine();

        while (choice != "exit")
        {
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("write - write a new entry");
            Console.WriteLine("add - adds a new prompt to randomly select");
            Console.WriteLine("display - display all of the journal's entries");
            Console.WriteLine("save - save the journal to a file of your choice");
            Console.WriteLine("load - load a journal from a file (warning: if you do not save your current journal first, all progress will be lost!)");
            Console.WriteLine("exit - end the program");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "write")
            {
                Entry newEntry = new Entry();
                DateTime currentTime = DateTime.Now;
                prompts.LoadPrompts();
                newEntry._date = currentTime.ToShortDateString();
                newEntry._prompt = prompts.GeneratePrompt();
                Console.WriteLine(newEntry._prompt);
                newEntry._response = Console.ReadLine();
                myJournal._entries.Add(newEntry);
            }

            // Added an option to allow the user to add their own custom prompts. These are saved to a file for future use.
            else if (choice == "add")
            {
                prompts.NewPrompt();
            }

            else if (choice == "display")
            {
                myJournal.Display();
            }

            else if (choice == "save")
            {
                myJournal.WriteFile();
            }

            else if (choice == "load")
            {
                myJournal._entries.Clear();
                Console.WriteLine("Please enter the name of the file you want to load from.");
                string loadFile = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(loadFile);

                foreach (string line in lines)
                {
                    Entry currentEntry = new Entry();
                    string[] parts = line.Split("~");

                    currentEntry._date = parts[0];
                    currentEntry._prompt = parts[1];
                    currentEntry._response = parts[2];
                    myJournal._entries.Add(currentEntry);
                }

                Console.WriteLine("Journal loaded!");
            }

            else if (choice != "exit")
            {
                Console.WriteLine("Invalid response. Please try again.");
            }
        }

        Console.WriteLine("Thank you for using the Journal program!");
    }
}