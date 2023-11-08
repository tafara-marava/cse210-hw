// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");
//     }
// }


Reference john = new Reference("John","1","37-38");
// john.Display();
Word firstWord = new Word("Jesus");
firstWord.HideWord();
List<Word> verseText = new List<Word>{firstWord,new Word("wept.")};
Scripture myScripture = new Scripture(john, verseText);
myScripture.DisplayVerse();

// Reference peter = new Reference("1 Peter","8","7");
// Scripture mySecondScripture = new Scripture(peter, "Jesus walked on the water");
// mySecondScripture.DisplayVerse();


// Reference a_ref = new Reference("A","Abraham Lincoln","");
// Encyclopedia A = new Encyclopedia(a_ref);