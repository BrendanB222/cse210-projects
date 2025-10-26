using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        scripture.MakeReference("Moroni", 10, 4, 5);
        int wordCount = scripture.MakeList();
        int hiddenWordCount = 0;
        string response = "";

        while (response != "quit" && hiddenWordCount != wordCount)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("(Press Enter to continue or type \"quit\" to quit.)");
            response = Console.ReadLine();
            hiddenWordCount += scripture.HideWords();
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine();
        Console.WriteLine();

        // Added an extra feature where the user can write back the scripture from memory.
        scripture.TestMemory();
    }
}