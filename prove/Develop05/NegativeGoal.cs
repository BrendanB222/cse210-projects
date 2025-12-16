using System;

public class NegativeGoal : Goal
{
    private string _type = "Negative";

    public NegativeGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    { }

    public override string GetGoal(int option)
    {
        if (option == 1)
        {
            return base.GetGoal(option) + " -- Bad Habit";
        }
        if (option == 3)
        {
            return _type + base.GetGoal(4);
        }

        else
        {
            return base.GetGoal(option);
        }
    }

    public override int RecordEvent()
    {
        return base.RecordEvent() * -1;
    }
}