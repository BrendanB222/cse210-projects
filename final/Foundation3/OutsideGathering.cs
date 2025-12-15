using System;

public class OutsideGathering : Event
{
    private string _weather;

    public OutsideGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine("Outside Gathering");
        Console.WriteLine($"Forecast: {_weather}");
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine("Outside Gathering");
        base.DisplayShortDescription();
    }
}