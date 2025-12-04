using System;

public class Goal
{
    // In addition to the parent class, this will also be the Eternal Goal class.
    private string _name;
    private string _description;
    private int _pointValue;

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    public virtual string GetGoal(int option)
    {
        // Option 1 is used when the user chooses to list the goals. Option 2 (or anything besides 1)
        // is used to list the goal's name when the user chooses to record an event.

        if (option == 1)
        {
            if (IsComplete())
            {
                return $"[X] {_name} ({_description})";
            }

            else
            {
                return $"[ ] {_name} ({_description})";
            }
        }

        else
        {
            return _name;
        }
    }

    public virtual int RecordEvent()
    {
        return _pointValue;
    }

    public virtual bool IsComplete()
    {
        return false;
    }
}