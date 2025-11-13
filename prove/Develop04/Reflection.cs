using System;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(string name, string description) : base(name, description)
    {}

    public string GetPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count());

        return _prompts[randomIndex];
    }

    public string GetQuestion()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _questions.Count());

        return _questions[randomIndex];
    }

    public void StartReflection()
    {
        BeginActivity();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            Console.Write($"> {GetQuestion()} ");
            Console.ReadLine();

            currentTime = DateTime.Now;
        }

        EndActivity();
    }
}