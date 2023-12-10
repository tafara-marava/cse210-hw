class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double _speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling: Speed {speed:F2} kph, Pace: {GetPace():F2} min per km";
    }
}