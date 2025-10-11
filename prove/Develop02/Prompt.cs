using System;
using System.IO;

public class Prompt
{
    public List<string> _prompts = new List<string>();

    public void LoadPrompts()
    {
        _prompts.Clear();
        string[] lines = System.IO.File.ReadAllLines("prompts.txt");

        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

    public string GeneratePrompt()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public void NewPrompt()
    {
        Console.WriteLine("Please write a new prompt to add to the list.");
        string newPrompt = Console.ReadLine();
        LoadPrompts();
        _prompts.Add(newPrompt);

        using (StreamWriter outputFile = new StreamWriter("prompts.txt"))
        {
            foreach (string prompt in _prompts)
            {
                outputFile.WriteLine(prompt);
            }
        }

        Console.WriteLine("Prompt added!");
    }
}