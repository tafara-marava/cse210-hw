public class Reference{
    string _book;
    string _chapter;
    string _verses;

public Reference(string book, string chapter, string verses){
    _book = book;
    _chapter = chapter;
    _verses = verses;
}

public void Display(){
    Console.WriteLine($"{_book} {_chapter}:{_verses}");
}

}

