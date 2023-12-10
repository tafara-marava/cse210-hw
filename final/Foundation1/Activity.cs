class Activity
{
    private DateTime date;
    protected int minutes;

    public Activity(DateTime _date, int _minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} - {minutes} min";
    }
}
