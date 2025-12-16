using System;

public class SimpleGoal : Goal
{
    private bool _completed;
    private string _type = "Simple";

    public SimpleGoal(string name, string description, int pointValue, bool completed = false) : base(name, description, pointValue)
    {
        _completed = completed;
    }

    public override string GetGoal(int option)
    {
        if (option == 1 || option == 2)
        {
            return base.GetGoal(option);
        }

        else
        {
            return _type + base.GetGoal(4) + $"~{_completed}";
        }
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