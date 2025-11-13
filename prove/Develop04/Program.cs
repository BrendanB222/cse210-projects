using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathingActivity = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflection reflectionActivity = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listingActivity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int choice = 0;

        Console.WriteLine("Welcome to the Mindfulness program!");
        Console.WriteLine();

        while (choice != 4)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Please select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Added a variable to the Activity class to keep track of the total number of seconds and times each activity was used this session.

            if (choice == 1)
            {
                breathingActivity.StartBreathing();
            }

            if (choice == 2)
            {
                reflectionActivity.StartReflection();
            }

            if (choice == 3)
            {
                listingActivity.StartListing();
            }
        }
    }
}