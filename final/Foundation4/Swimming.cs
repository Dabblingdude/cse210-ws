class Swimming : Activity
{
    private double _laps;
    private double _lapLength = 50.0 / 1000 * 0.62;

    public Swimming(string date, double duration, double laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _lapLength;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }
}
