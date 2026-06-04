using System;

public abstract class Activity
{
    protected string _date;
    protected string _name;
    protected double _duration;

    public Activity(string date, string name, double duration)
    {
        _date = date;
        _name = name;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_duration} min) Distance: {GetDistance():0.00} m, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/m";
    }
}