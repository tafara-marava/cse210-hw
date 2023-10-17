using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public class Prompts{
    private List<string> userPrompt = new List<string>()
    {
        "How was your day", 
        "what are you grateful for? " , 
        "what did you learn? "
    };

    int randomNumber = 0;
    public Prompts(){

    }
    public string DisplayPrompt(){
    Random randomPrompt = new Random();
    randomNumber =  randomPrompt.Next(0,userPrompt.Count);
    return userPrompt[randomNumber];
    }
}

