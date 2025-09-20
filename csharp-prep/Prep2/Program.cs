using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade % 10 >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            letterGrade += "+";
        }
        else if (grade % 10 < 3 && letterGrade != "F")
        {
            letterGrade += "-";
        }

        Console.WriteLine($"You earned a grade {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time.");
        }
    }
}