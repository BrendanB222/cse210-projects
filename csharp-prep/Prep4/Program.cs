using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;
        int sum = 0;
        int largestNumber = 0;
        int smallestNumber = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        float average = (float)sum / (float)numbers.Count;
        Console.WriteLine($"The average is: {average}");

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (smallestNumber == 0 && number > 0)
            {
                smallestNumber = number;
            }
            else if (smallestNumber != 0 && number < smallestNumber && number > 0)
            {
                smallestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}