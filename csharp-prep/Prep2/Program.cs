using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade for this class: ");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);

        if (grade >= 90)
        {
            Console.WriteLine("You scored an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You scored an B");  
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You scored an C");  
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You scored an D");  
        }
        else 
        {
            Console.WriteLine("You scored an F"); 
            Console.WriteLine("This is not the end of the world, you can try again next semester"); 
        }
    }
}