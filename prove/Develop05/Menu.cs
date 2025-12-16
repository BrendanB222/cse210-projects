using System;

public class Menu
{
    private int _totalPoints;
    private List<Goal> _goals = new List<Goal>();

    public Menu()
    {
        _totalPoints = 0;
    }

    public void SaveFile()
    {
        Console.WriteLine("Please enter the name of the file you want to save to.");
        string saveFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetGoal(3));
            }
        }

        Console.WriteLine("Goals saved!");
        Console.WriteLine();
    }

    public void LoadFile()
    {
        Console.WriteLine("Please enter the name of the file you want to load from.");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        _totalPoints = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            if (parts[0] == "Eternal")
            {
                Goal newGoal = new Goal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(newGoal);
            }

            else if (parts[0] == "Simple")
            {
                SimpleGoal newGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(newGoal);
            }

            else if (parts[0] == "Checklist")
            {
                ChecklistGoal newGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(newGoal);
            }

            if (parts[0] == "Negative")
            {
                NegativeGoal newGoal = new NegativeGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(newGoal);
            }
        }

        Console.WriteLine("Goals loaded!");
        Console.WriteLine();
    }

    public void MenuFunction()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"You have {_totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // Added a Negative/Bad Habit goal type.
                
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Bad Habit");
                Console.Write("Which type of goal would you like to create? ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is the short description of your goal? ");
                string description = Console.ReadLine();

                if (type == 1)
                {
                    Console.Write("How many points is this goal worth? ");
                    int pointValue = int.Parse(Console.ReadLine());
                    SimpleGoal newGoal = new SimpleGoal(name, description, pointValue);
                    _goals.Add(newGoal);
                }

                else if (type == 2)
                {
                    Console.Write("How many points is this goal worth? ");
                    int pointValue = int.Parse(Console.ReadLine());
                    Goal newGoal = new Goal(name, description, pointValue);
                    _goals.Add(newGoal);
                }

                else if (type == 3)
                {
                    Console.Write("How many points is this goal worth? ");
                    int pointValue = int.Parse(Console.ReadLine());
                    Console.Write("How many times would you like to complete this goal? ");
                    int targetCompletion = int.Parse(Console.ReadLine());
                    Console.Write("How many bonus points would you like to receive upon full completion? ");
                    int bonusValue = int.Parse(Console.ReadLine());

                    ChecklistGoal newGoal = new ChecklistGoal(name, description, pointValue, bonusValue, targetCompletion);
                    _goals.Add(newGoal);
                }

                else if (type == 4)
                {
                    Console.Write("How many points will this goal make you lose? ");
                    int pointValue = int.Parse(Console.ReadLine());
                    NegativeGoal newGoal = new NegativeGoal(name, description, pointValue);
                    _goals.Add(newGoal);
                }

                Console.WriteLine();
            }

            else if (choice == 2)
            {
                Console.WriteLine("Your goals:");

                for (var i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetGoal(1)}");
                }

                Console.WriteLine();
            }

            else if (choice == 3)
            {
                SaveFile();
            }

            else if (choice == 4)
            {
                LoadFile();
            }

            else if (choice == 5)
            {
                Console.WriteLine("Your goals:");

                for (var i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetGoal(2)}");
                }

                Console.Write("Which goal did you accomplish? ");
                int accomplished = int.Parse(Console.ReadLine()) - 1;
                int points = _goals[accomplished].RecordEvent();

                if (points >= 0)
                {
                    Console.WriteLine($"Congratulations! You earned {points} points.");
                }

                else
                {
                    Console.WriteLine($"Oh no! You lost {points * -1} points.");
                }

                _totalPoints += points;
                Console.WriteLine();
            }
        }
    }
}