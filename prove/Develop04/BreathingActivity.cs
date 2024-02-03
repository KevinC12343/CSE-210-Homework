using System;

class Breathing
{
    public void BreathingActivity()
    {
    }
    public  void Run()
    {
        Console.WriteLine("Welcome to the Breathing Activity");

        Console.WriteLine("This Activity will help you relax by running you through breathing in/out slowly. Clear your mind and focus on just your breathing.");

        Console.WriteLine("how long in seconds, would you like for your session? ");
        int responce2 = int.Parse(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(responce2);
        
        Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("Well Done!!");
            Thread.Sleep(2000);
            Console.WriteLine($"You have completed another {responce2} seconds of the breathing Activity");
        }


    }

}