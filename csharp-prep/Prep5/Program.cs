using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();
        int usernum = PromptUserNumber();

        int squaredNumber = SquareNumber(usernum);
        
        DisplayResults(name, squaredNumber);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to my Fun little program");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please Enter your Favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}