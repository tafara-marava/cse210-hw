class Reception : Event
{
    private string _rsvpEmail;

    public new void SetEventDetails()
    {
        base.SetEventDetails(); // Set details for the base event

        Console.Write("Enter RSVP Email: ");
        _rsvpEmail = Console.ReadLine();
    }

    public new string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}