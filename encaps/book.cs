public class Book{
    private string _author
    private string _name
    private string _timesRead
    private boolean _available

public Book(string name, string author){
    _timesRead = 0;
    _available = true;
    _name = name;
    _author = author;
}
public void Display(){
    Console.WriteLine("Author: "_author)
    Console.WriteLine("Name: "_name)
    Console.WriteLine("Times read: "_timesRead)
    Console.WriteLine("Available: "_available)
}

}
