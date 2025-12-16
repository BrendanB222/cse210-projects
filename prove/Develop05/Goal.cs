using System;

public class Goal
{
    // In addition to the parent class, this will also be the Eternal Goal class.
    private string _name;
    private string _description;
    private int _pointValue;
    private string _type = "Eternal";

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    public virtual string GetGoal(int option)
    {
        // Option 1 is used when the user chooses to list the goals. Option 2 is used to list the
        // goal's name when the user chooses to record an event. Option 3 is used when saving as a file.
        // Option 4 (or anything other than 1, 2, or 3) passes the goal information to the child classes.

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

        else if (option == 2)
        {
            return _name;
        }

        else if (option == 3)
        {
            return $"{_type}~{_name}~{_description}~{_pointValue}";
        }

        else
        {
            return $"~{_name}~{_description}~{_pointValue}";
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