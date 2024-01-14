using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your Grade percentage: ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if(percentage >=80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if(percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.Write("Your grade is " + letter);

        if (percentage >= 70)
        {
            Console.Write(" You passed! Good job!");
        }
        else
        {
            Console.Write(" You failed, but keep trying, dont give up");
        }
    }
}