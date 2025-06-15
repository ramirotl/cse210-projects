using System;
using System.Collections.Generic;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string userInput = "";
        while (userInput != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();


            if (userInput == "1")
            {
                CreateGoal();
            }
            else if (userInput == "2")
            {
                // ListGoalName();??
                ListGoalDetails();
            }
            else if (userInput == "3")
            {
                SaveGoals();
            }
            else if (userInput == "4")
            {
                LoadGoals();
            }
            else if (userInput == "5")
            {
                RecordEvent();
            }
            else if (userInput == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalName()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }

    }
    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (goalType == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (goalType == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Please try again.");
        }

    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        Console.WriteLine();
        ListGoalName();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            selectedGoal.RecordEvent();

            if (selectedGoal is ChecklistGoal cg && cg.IsComplete())
            {
                _score += cg.GetPoints() + cg.GetBonus(); // Create GetBonus()
            }
            else
            {
                _score += selectedGoal.GetPoints();
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
        // string input = Console.ReadLine();
        // int choice;
        // if (int.TryParse(input, out choice) && choice >= 1 && choice <= _goals.Count)
        // {
        //     Goal selectedGoal = _goals[choice - 1];

        //     // Before recording the event, we store the initial score
        //     int initialScore = _score;

        //     // Record the event for the selected goal
        //     selectedGoal.RecordEvent();

        //     // After recording the event, we check if the goal is complete and update the score accordingly
        //     if (selectedGoal is SimpleGoal && selectedGoal.IsComplete())
        //     {
        //         _score += selectedGoal.GetPoints();
        //     }
        //     else if (selectedGoal is EternalGoal)
        //     {
        //         _score += selectedGoal.GetPoints();
        //     }
        //     else if (selectedGoal is ChecklistGoal checklist)
        //     {
        //         // Check if the checklist goal is complete and if it has been completed multiple times
        //         if (checklist.IsComplete() && checklist.GetStringRepresentation().Contains($"|{checklist.GetPoints()}|{checklist.GetPoints()}|{checklist.GetPoints()}|"))
        //         {
        //             _score += checklist.GetPoints() + checklist.GetPoints();
        //         }
        //         else
        //         {
        //             _score += checklist.GetPoints();
        //         }
        //     }

        //     Console.WriteLine($"Your current score is now {_score} points.\n");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid selection. Please try again.");
        // }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter OutputFile = new StreamWriter(filename))
        {
            OutputFile.WriteLine(_score); // Save the current score at the top of the file
            foreach (Goal goal in _goals)
            {
                OutputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
            return;
        }
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear(); // Clear existing goals before loading new ones

        string scoreLine = lines[0];
        _score = int.Parse(scoreLine); // Load the score from the first line
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string type = parts[0];
            string[] data = parts[1].Split('|');

            if (type == "SimpleGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool isComplete = bool.Parse(data[3]);
                SimpleGoal goal = new SimpleGoal(name, description, points);

                // Set the completion status
                if (isComplete)
                {
                    goal.RecordEvent(); // Mark the goal as complete
                }

                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int target = int.Parse(data[3]);
                int amountCompleted = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                // Simulate the completion of the goal by recording the event multiple times
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals and score loaded successfully.\n");
    }
}