using System;

public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private int _duration;
    private string _type;

    public Activity(int duration, string type)
    {
        _duration = duration;
        _type = type;
    }

    public abstract double GetDistance();

    public abstract double GetPace();

    public abstract double GetSpeed();

    public string GetSummary()
    { 
        return $"{_date.ToString("dd MMM yyyy")} {_type} ({_duration} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }

    public int GetDuration()
    {
        return _duration;
    }
}