using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, string name, double duration, int laps) : base(date, name, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50.0) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60.0;
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }
}