using System;
public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _completed = false;
    }

    public override int RecordEvent()
    {
        _completed = true;

        return _points;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetDetails()
    {
        string box = "[ ]";

        if (_completed)
        {
            box = "[X]";
        }

        return $"{box} {_name} ({_description})";
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_completed}";
    }
}