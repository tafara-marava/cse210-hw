public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in entries)
            {
                writer.Write(entry.ToFileString());
            }
        }
        Console.WriteLine($"Journal entries saved to {filePath}");
    }

    public void LoadFile(string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);

foreach (string line in lines)
{
    string[] parts = line.Split(":");
    // parts = ["what are you greatfe", "family"]

    string question = parts[0];
    string answer = parts[1];

    // question = "what are you greatfe"
    // answer = "family"

    Entry entry = new Entry(question, answer);
    AddEntry(entry);
    // entry = new Entry ("what are ...", "Family")
}
    }
}