class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public new void SetEventDetails()
    {
        base.SetEventDetails(); // Set details for the base event

        Console.Write("Enter Speaker Name: ");
        _speaker = Console.ReadLine();

        Console.Write("Enter Capacity: ");
        if (int.TryParse(Console.ReadLine(), out int capacity))
        {
            _capacity = capacity;
        }
        else
        {
            Console.WriteLine("Invalid capacity. Using default value (0).");
            _capacity = 0;
        }
    }

    public new string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}