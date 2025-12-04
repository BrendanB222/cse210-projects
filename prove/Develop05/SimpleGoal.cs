using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int pointValue, bool completed = false) : base(name, description, pointValue)
    {
        _completed = completed;
    }

    public override string GetGoal(int option)
    {
        return base.GetGoal(option);
    }

    public override int RecordEvent()
    {
        _completed = true;
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return _completed;
    }
}