using System;

class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}








class Program
{
    static void Main()
    {
        var genericEvent = new Event();
        genericEvent.SetEventDetails();

        var lectureEvent = new Lecture();
        lectureEvent.SetEventDetails();

        var receptionEvent = new Reception();
        receptionEvent.SetEventDetails();

        var outdoorEvent = new OutdoorGathering();
        outdoorEvent.SetEventDetails();

        Console.WriteLine("\nGeneric Event:\n");
        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine(genericEvent.GetFullDetails());
        Console.WriteLine(genericEvent.GetShortDescription());
        Console.WriteLine("\n-----------------\n");

        Console.WriteLine("Lecture Event:\n");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine("\n-----------------\n");

        Console.WriteLine("Reception Event:\n");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine("\n-----------------\n");

        Console.WriteLine("Outdoor Event:\n");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
