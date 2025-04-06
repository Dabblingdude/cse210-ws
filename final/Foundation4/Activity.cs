using System;

abstract class Activity
{
    private string _date;
    private double _duration;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date}\n{GetType().Name} for {_duration} min\nDistance: {GetDistance()} miles\nSpeed: {GetSpeed()} mph\nPace: {GetPace()} minutes per mile\n\n";
    }
}