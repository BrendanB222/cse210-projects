using System;

public class ChecklistGoal : Goal
{
    private int _bonusValue;
    private int _timesCompleted;
    private int _targetCompletion;
    private string _type = "Checklist";

    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int targetCompletion, int timesCompleted = 0) : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _timesCompleted = timesCompleted;
        _targetCompletion = targetCompletion;
    }

    public override string GetGoal(int option)
    {
        if (option == 1)
        {
           return base.GetGoal(option) + $" -- Completed {_timesCompleted}/{_targetCompletion}"; 
        }

        else if (option == 2)
        {
            return base.GetGoal(option);
        }

        else
        {
            return _type + base.GetGoal(4) + $"~{_bonusValue}~{_targetCompletion}~{_timesCompleted}";
        }
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (IsComplete())
        {
            return base.RecordEvent() + _bonusValue;
        }

        else
        {
            return base.RecordEvent();
        }
    }

    public override bool IsComplete()
    {
        if (_timesCompleted == _targetCompletion)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}