using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _time;

    // Added these variables to keep track of the user's statistics for each activity this session.
    private int _totaltime = 0;
    private int _timesused = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void BeginActivity()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How many seconds would you like to spend on this activity? ");
        _time = int.Parse(Console.ReadLine());
        _totaltime += _time;
        _timesused++;

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner();
        Console.WriteLine($"You have completed {_time} seconds of the {_name} Activity.");
        Console.WriteLine($"You have completed this activity {_timesused} time(s) this session for a total time of {_totaltime} seconds.");
        DisplaySpinner();
        Console.Clear();
    }

    public void DisplayCountdown(int time)
    {
        while (time > 0)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;
        }

        Console.WriteLine();
    }

    public void DisplaySpinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        DateTime currentTime = DateTime.Now;

        for (int i = 1; i < 5; i++)
        {
            Console.Write("-");
            Thread.Sleep(312);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(312);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(312);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(312);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
}