using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_title}: {_description}");
        Console.WriteLine($"{_date}, {_time}");
        Console.WriteLine(_address.GetAddress());
    }

    public virtual void DisplayFullDetails()
    {
        DisplayStandardDetails();
    }

    public virtual void DisplayShortDescription()
    {
        Console.WriteLine($"{_title}, {_date}");
    }
}