class Activity{
    string _activity;
    string _description;
    int _duration;


    public Activity(string activity, string description, int duration)
    {
        _activity = activity;
        _description = description;
        _duration = duration;
    } 

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_activity}: {_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_activity}: {_description}");
    }
    public void PauseWhileSpinner()
    {
        Console.WriteLine("Pausing while spinner is active...");
        // Simulate pausing for a duration (e.g., _duration) using Thread.Sleep
        Thread.Sleep(_duration * 1000); // Convert seconds to milliseconds
        Console.WriteLine("Resuming after pause.");
    }

    public void PauseWhileTimer()
    {
        Console.WriteLine("Pausing while timer is active...");
        // Simulate pausing for a duration (e.g., _duration) using Thread.Sleep
        Thread.Sleep(_duration * 1000); // Convert seconds to milliseconds
        Console.WriteLine("Resuming after pause.");
    }
    
}

class BreathingActivity : Activity
{
    private int _rounds;

    public BreathingActivity(string activity, string description, int duration, int rounds)
        : base(activity, description, duration)
    {
        _rounds = rounds;
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        for (int round = 1; round <= _rounds; round++)
        {
            Console.WriteLine($"Round {round} - Breathe in and out deeply.");
            PauseWhileSpinner();
        }
        DisplayEndingMessage();
    }

    public void BreathingO()
    {
        Console.WriteLine("Performing a special breathing exercise...");
        PauseWhileTimer();
        Console.WriteLine("Breathing exercise completed.");
    }
}