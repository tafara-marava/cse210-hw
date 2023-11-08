using System.Diagnostics;

public class Menu 
{
    List<string> myList = new List<string>(){
        "1.Write",
        "2.Display",
        "3.Load",
        "4.Save",
        "5.Quit"
    };

    public Menu(){

    }
    
    int option = 0;
    public void DisplayMenu(){
        Console.WriteLine("Please select one fo the following choices: ");
        foreach(string item in myList){

            Console.WriteLine(item);
            // if (option == 1){
                
            // }
        }
    }
    

}
    

