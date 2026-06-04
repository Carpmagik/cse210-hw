using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, string name, double duration, double speed) : base(date, name, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_duration / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}