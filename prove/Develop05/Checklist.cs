public class Checklist : Goal
{
    private int totalCompletions;
    private int currentCompletions;

    public Checklist(string name, int value, int totalCompletions) : base(name, value)
    {
        this.totalCompletions = totalCompletions;
        this.currentCompletions = 0;
    }

    public override void Complete()
    {
        currentCompletions++;

        if (currentCompletions == totalCompletions)
        {
            Console.WriteLine($"Goal '{name}' completed! Gained {value} points and a bonus of {value * totalCompletions} points.");
        }
        else
        {
            Console.WriteLine($"Recorded '{name}'! Gained {value} points. Completed {currentCompletions}/{totalCompletions} times.");
        }
    }

    public override string GetStatus()
    {
        return $"Completed {currentCompletions}/{totalCompletions} times";
    }
}
