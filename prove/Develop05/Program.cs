using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal goal1 = new SimpleGoal("test goal", "for testing purposes", 20);
        Console.WriteLine(goal1.GetGoal(1));
        goal1.RecordEvent();
        Console.WriteLine(goal1.GetGoal(1));

        ChecklistGoal goal2 = new ChecklistGoal("test goal 2", "also for testing purposes", 20, 200, 3);
        Console.WriteLine(goal2.GetGoal(1));
        goal2.RecordEvent();
        Console.WriteLine(goal2.GetGoal(1));
        goal2.RecordEvent();
        Console.WriteLine(goal2.GetGoal(1));
        goal2.RecordEvent();
        Console.WriteLine(goal2.GetGoal(1));
    }
}