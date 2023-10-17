public class Program
{
    public static void Main(string[] args)
    {
        Prompts prompts = new Prompts();
        Journal journal = new Journal();

        while (true)
        {
            string question = prompts.DisplayPrompt();
            if (string.IsNullOrWhiteSpace(question))
            {
                break; // Exit the program when user cancels
            }

            Console.Write($"{question}: ");
            string answer = Console.ReadLine();

            Entry entry = new Entry(question, answer);
            journal.AddEntry(entry);
        }

        Console.WriteLine("Your journal entries:");
        journal.DisplayEntries();

        Console.Write("Enter the file path to save your journal entries (e.g., journal.txt): ");
        string filePath = Console.ReadLine();

        journal.SaveToFile(filePath);
    }
}