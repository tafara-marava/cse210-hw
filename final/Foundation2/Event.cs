class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event()
    {
        _address = new Address();
    }

    public void SetEventDetails()
    {
        Console.Write("Enter Event Title: ");
        _title = Console.ReadLine();

        Console.Write("Enter Event Description: ");
        _description = Console.ReadLine();

        Console.Write("Enter Event Date (MM/dd/yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
        {
            _date = date;
        }
        else
        {
            Console.WriteLine("Invalid date format. Using the current date.");
            _date = DateTime.Now;
        }

        Console.Write("Enter Event Time (HH:mm): ");
        if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan time))
        {
            _time = time;
        }
        else
        {
            Console.WriteLine("Invalid time format. Using the current time.");
            _time = DateTime.Now.TimeOfDay;
        }

        Console.Write("Enter Street Address: ");
        _address.Street = Console.ReadLine();

        Console.Write("Enter City: ");
        _address.City = Console.ReadLine();

        Console.Write("Enter State: ");
        _address.State = Console.ReadLine();

        Console.Write("Enter Zip Code: ");
        _address.ZipCode = Console.ReadLine();
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    public string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}