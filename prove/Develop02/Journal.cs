using System;
using System.IO;

public class Journal
{
    public string _name;
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine($"{_name}'s Journal");

        foreach (Entry entry in _entries)
        {
            Console.WriteLine();
            entry.DisplayEntry();
        }
    }

    public void WriteFile()
    {
        Console.WriteLine("Please enter the name of the file you want to save to.");
        string saveFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._response}");
            }
        }

        Console.WriteLine("Journal saved!");
    }
}