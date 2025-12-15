using System;

public class Running : Activity
{
    private double _distance;

    public Running(int duration, double distance, string type="Running") : base(duration, type)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return base.GetDuration() / _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base.GetDuration()) * 60;
    }
}