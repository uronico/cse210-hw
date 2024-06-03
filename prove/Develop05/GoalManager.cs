using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void Start()
    {
        LoadGoals();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.GetStringRepresentation()} - {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        if (type == "Simple")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (type == "Eternal")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (type == "Checklist")
        {
            Console.Write("Enter target: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            throw new Exception("Invalid goal type");
        }

        goals.Add(goal);
    }

    public void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Goal goal = goals.Find(g => g.name == name);
        if (goal != null)
        {
            goal.RecordEvent();
            score += goal.points;
        }
        else
        {
            Console.WriteLine("Goal not found");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save the goals: ");
        string fileName = Console.ReadLine();
        

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()} - {goal.GetDetailsString()}");
            }
        }

        Console.WriteLine("Goals saved to file successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load the goals: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
       {

           using (StreamReader reader = new StreamReader(fileName))
           {
               while (!reader.EndOfStream)
               {
                    string[] parts = reader.ReadLine().Split('-');
                    Goal loadedEntry = new SimpleGoal(parts[0], parts[1], score);   
                    goals.Add(loadedEntry);
                }
            }

            Console.WriteLine("Goals loaded from file successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
