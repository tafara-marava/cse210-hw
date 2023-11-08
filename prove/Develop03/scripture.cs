public class Scripture{
    Reference _reference;

    // string _verseText;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, List<Word> verseText){
        _reference = reference;
        _words = verseText;
    }

    public void DisplayVerse()
    {
        _reference.Display();
        foreach (Word word in _words)
        {
            word.Display();
        }
        // Console.WriteLine(_verseText);
    }
}