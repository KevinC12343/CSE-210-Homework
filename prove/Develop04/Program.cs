using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menue Options: ");
        Console.WriteLine("1, Breathing");
        Console.WriteLine("2, reflecting");
        Console.WriteLine("3, Start Listing Activity");
        Console.WriteLine("4, quit");
        int responce = int.Parse(Console.ReadLine());

        if (responce == 1)
        {
            //Get.BreathingActivity.Run();
        }
        else if (responce == 2)
        {
            //Get.ReflectingActivity.Run();
        }
        else if (responce == 3)
        {
            //Get.ListingActivity.Run();

        }
        else if (responce == 4)
        {
            System.Environment.Exit(0);
        }

    }
}