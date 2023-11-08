using System.Security.Cryptography.X509Certificates;

public class Word{
    private string _word;
    private string _hiddenWord;
    private bool _isHidden = false;

    public Word(string word){
        _word = word;
        int wordLength = word.Length;
        for (int i = 0; i <= wordLength -1; i++)
        {
            _hiddenWord = _hiddenWord + "_";
        }
        
    }
    public void Display(){
        if (_isHidden)
        {
            Console.Write($"{_hiddenWord} ");
        }
        else{
            Console.Write($"{_word} ");
        }
    }

    public void HideWord(){
        _isHidden = true;
    }
        
}