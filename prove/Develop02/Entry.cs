// public class Entry{
// string _question = "";
// string _answer = "";

// public Entry(string question, string answer){
// _question = question;
// _answer = answer;
// }

// public void DisplayEntry(){
//     Console.WriteLine("*****************************");
//     Console.WriteLine(_question);
//     Console.WriteLine(_answer);

// }

// }

public class Entry
{
    private string _question;
    private string _answer;

    public Entry(string question, string answer)
    {
        _question = question;
        _answer = answer;
    }

    public void DisplayEntry()
    {
        Console.WriteLine("*****************************");
        Console.WriteLine(_question);
        Console.WriteLine(_answer);
    }

    public string ToFileString()
    {
        // Convert the Entry to a string for saving to a file
        return $"{_question}\n{_answer}\n";
    }
}