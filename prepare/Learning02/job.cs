using System;

public class Job
{
    public string _title;
    public string _comp;
    public int _startyr;
    public int _endyr;

     public void Display()
     {
        Console.WriteLine($"{_title} ({_comp}) ({_startyr}) ({_endyr}");
     }
}