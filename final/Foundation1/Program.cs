using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Console.WriteLine("Enter Running details:");
        DateTime runningDate = GetUserInputDate();
        int runningMinutes = GetUserInputMinutes("Running duration in minutes: ");
        double runningDistance = GetUserInputDouble("Running distance in miles: ");
        activities.Add(new Running(runningDate, runningMinutes, runningDistance));

        Console.WriteLine("\nEnter Cycling details:");
        DateTime cyclingDate = GetUserInputDate();
        int cyclingMinutes = GetUserInputMinutes("Cycling duration in minutes: ");
        double cyclingSpeed = GetUserInputDouble("Cycling speed in kph: ");
        activities.Add(new Cycling(cyclingDate, cyclingMinutes, cyclingSpeed));

        Console.WriteLine("\nEnter Swimming details:");
        DateTime swimmingDate = GetUserInputDate();
        int swimmingMinutes = GetUserInputMinutes("Swimming duration in minutes: ");
        int swimmingLaps = GetUserInputInt("Number of swimming laps: ");
        activities.Add(new Swimming(swimmingDate, swimmingMinutes, swimmingLaps));

        Console.WriteLine("\nActivities Summary:");

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    static DateTime GetUserInputDate()
    {
        Console.Write("Enter date (yyyy-MM-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.Write("Invalid date format. Please enter a valid date (yyyy-MM-dd): ");
        }
        return date;
    }

    static int GetUserInputMinutes(string prompt)
    {
        Console.Write(prompt);
        int minutes;
        while (!int.TryParse(Console.ReadLine(), out minutes) || minutes <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer for minutes: ");
        }
        return minutes;
    }

    static double GetUserInputDouble(string prompt)
    {
        Console.Write(prompt);
        double value;
        while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number: ");
        }
        return value;
    }

    static int GetUserInputInt(string prompt)
    {
        Console.Write(prompt);
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }
        return value;
    }
}
