using System;

public class Listing : Activity
{
    private int _itemCounter;

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(string name, string description) : base(name, description)
    { }

    public string GetPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count());

        return _prompts[randomIndex];
    }
    
    public void StartListing()
    {
        BeginActivity();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetPrompt()} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            Console.Write($"> ");
            Console.ReadLine();

            currentTime = DateTime.Now;
            _itemCounter++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_itemCounter} items!");

        EndActivity();
    }
}