using System;

public class Running : Activity
{
    private double _distance;
    public Running(string date, string name, double duration, double distance) : base(date, name, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60.0;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }
}