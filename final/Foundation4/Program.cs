using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(30, 3);
        activities.Add(running);
        Cycling cycling = new Cycling(30, 7);
        activities.Add(cycling);
        Swimming swimming = new Swimming(30, 5);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}