class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string _streetAddress, string _city, string _state, string _country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{streetAddress}, {city}, {state}, {country}";
    }
}
