using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Choose an option bellow: ");
        Console.WriteLine("1, Write ");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit");
        string responce1 = Console.ReadLine();
        int Choice = int.Parse(responce1);

        if (Choice == 1)
        {
            string _promptText = Console.ReadLine();
            Console.WriteLine("Enter Your text: ");
        }
        else if (Choice == 2)
        {
            Console.WriteLine();
        }
        else if (Choice == 3)
        {
            Console.WriteLine();
        }
        else if (Choice == 4)
        {
            Console.WriteLine();
        }
        else if (Choice == 5)
        {
            Console.WriteLine();
        }
    }
}