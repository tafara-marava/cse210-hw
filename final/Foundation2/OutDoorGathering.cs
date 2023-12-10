class OutdoorGathering : Event
{
    private string _weatherStatement;

    public new void SetEventDetails()
    {
        base.SetEventDetails(); // Set details for the base event

        Console.Write("Enter Weather Statement: ");
        _weatherStatement = Console.ReadLine();
    }

    public new string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}";
    }
}
