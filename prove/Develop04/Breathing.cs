using System;

public class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {}

    public void StartBreathing()
    {
        BeginActivity();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            DisplayCountdown(5);
            Console.Write("Breathe out... ");
            DisplayCountdown(5);

            currentTime = DateTime.Now;
        }

        EndActivity();
    }
}