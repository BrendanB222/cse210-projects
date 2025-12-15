using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(int duration, double speed, string type="Cycling") : base(duration, type)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * base.GetDuration();
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}