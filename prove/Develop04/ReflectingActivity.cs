using System;
using System.Security.Cryptography.X509Certificates;

class Reflecting
{
    private const string V = "hi";

    static void ReflectingActivity(){
        List<String> _prompts = new List<string>();
        List<string> _questions = new List<string>();

        _prompts.Add("When was the last time you felt happy?");
        _prompts.Add("When was the last time you did something to help others?");
        _prompts.Add("When was the last time you felt good?");
        _prompts.Add("When was the last time you had fresh air?");
        _prompts.Add("When was the last time you spent time with family/friends?");

        _questions.Add("What were you thinking when you read the question?");
        _questions.Add("Can you do better?");
        _questions.Add("Could you start to do these?");
    }
    public static void ReflectingAcrtivity()
    {
        
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Reflecting Activity");

        Console.WriteLine("This Activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you Recognize the power you have and how you can use it in your life");

        Console.WriteLine("how long in seconds, would you like for your session? ");
        int responce3 = int.Parse(Console.ReadLine());

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(responce3);
        
        Thread.Sleep(3000);
        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("Well Done!!");
            Thread.Sleep(2000);
            Console.WriteLine($"You have completed another {responce3} seconds of the Reflecting Activity");
        }


    }
    public string GetRandomQuestion()
    {
        return V;

    }
    public string GetRandomPrompt()
    {
        return V;
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
}