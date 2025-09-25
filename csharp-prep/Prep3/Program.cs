using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            Console.WriteLine("A magic number has been chosen.");
            int guessCount = 0;
            int guess = 0;

            while (guess != number)
            {
                guessCount++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You guessed {guessCount} times.");
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        }
    }
}