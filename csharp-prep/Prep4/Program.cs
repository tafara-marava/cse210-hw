using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        
        while (true)
        {
            Console.WriteLine("Please enter a number, type zero when finished");
            int userNum = int.Parse(Console.ReadLine());
            numbers.Add(userNum);

            if (userNum == 0)
            {
                break;
            }
        }
        int total = numbers.Sum();
        int biggestNum = numbers.Max();
        int avgNum = (int)numbers.Average();

        Console.WriteLine("Your numbers are:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"The total of the numbers in your list is {total}");
        Console.WriteLine($"The biggest of all the numbers in your list is {biggestNum}");
        Console.WriteLine($"The average of the numbers in your list is {avgNum}");
    }
}