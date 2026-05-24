// ChecklistGoal.cs

using System;
public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description,
        int points, int target, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _target;
    }

    public override string GetDetails()
    {
        string box = "[ ]";

        if (IsComplete())
        {
            box = "[X]";
        }

        return $"{box} {_name} ({_description}) -- Completed {_timesCompleted}/{_target}";
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_timesCompleted}";
    }
}