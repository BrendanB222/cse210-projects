using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine("Reception");
        Console.WriteLine($"RSVP: {_email}");
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine("Reception");
        base.DisplayShortDescription();
    }
}