using System;

class Program
{
    static void Main(string[] args)
    {
        static void welcomeMessage()
        {
        Console.WriteLine("Welcome to the Program! ");
        }

        static string AskUserName()
        {
            Console.WriteLine("what is yout name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        Main();
    }
}