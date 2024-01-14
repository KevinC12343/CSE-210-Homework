using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the Magic number?: ");
        //int MagicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int MagicNumber=randomGenerator.Next(1,101);

        int guess = -1;

    while (guess != MagicNumber)
    {
        Console.WriteLine("What is your guess?: ");
        guess = int.Parse(Console.ReadLine());
        
        if (MagicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        if (MagicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Good job, you guessed it!");
        }
    }
    }
}