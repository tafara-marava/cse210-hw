using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        int magicNumber = 5;
        int guess = 0;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());

            guess = userGuess; // Update the guess with the user's input

            if (guess > magicNumber)
            {
                Console.WriteLine("Guess lower ");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess higher ");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
