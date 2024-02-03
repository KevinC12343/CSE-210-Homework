using System;
public class ListingActivity
{
    int _count;
    List<String> _prompts = new List<string>();

    public ListingActivity()
    {

    }
    public void Run()
    {
        Console.WriteLine("Welcome to the Listing Activity");

        Console.WriteLine("This Activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you Recognize the power you have and how you can use it in your life");

        Console.WriteLine("how long in seconds, would you like for your session? ");
        int responce4 = int.Parse(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(responce4);
        
        Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("Well Done!!");
            Thread.Sleep(2000);
            Console.WriteLine($"You have completed another {responce4} seconds of the Reflecting Activity");

    }

}
}
