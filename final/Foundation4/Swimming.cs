using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(int duration, double laps, string type="Swimming") : base(duration, type)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return base.GetDuration() / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / base.GetDuration()) * 60;
    }
}