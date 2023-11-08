public class Program
{
    public static void Main(string[] args)
    {
        Prompts prompts = new Prompts();
        Journal journal = new Journal();
        Menu menu = new Menu();

      

        int choice = 0;
       
        while (choice != 5){
        menu.DisplayMenu();  
        choice = int.Parse(Console.ReadLine());
        if(choice == 1){
            
        
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
        
        }
        
       

        Console.WriteLine("Your journal entries:");
        journal.DisplayEntries();

        Console.Write("Enter the file path to save your journal entries (e.g., journal.txt): ");
        string filePath = Console.ReadLine();

        journal.SaveToFile(filePath);
    }
}