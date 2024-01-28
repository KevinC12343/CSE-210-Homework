using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to Continue or type 'quit' to finish: ");
        String responce = Console.ReadLine();


        if (responce == "quit")
        {
            System.Environment.Exit(0);
        }
        else
        {
                Console.Write(Refrence);
                Console.Write(Scripture);
                Console.Write(Word);
        }
        
}
}