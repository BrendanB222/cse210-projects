using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine("Lecture");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine("Lecture");
        base.DisplayShortDescription();
    }
}