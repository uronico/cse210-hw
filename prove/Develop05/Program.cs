using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        GoalManager manager = new GoalManager();
        manager.Start();

       while (true)
        {
            Console.WriteLine("1. Display player info");
            Console.WriteLine("2. List goal names");
            Console.WriteLine("3. List goal details");
            Console.WriteLine("4. Create a new goal");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. Load goals");
            Console.WriteLine("8. Quit");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    manager.DisplayPlayerInfo();
                    break;
                case 2:
                    manager.ListGoalNames();
                    break;
                case 3:
                    manager.ListGoalDetails();
                    break;
                case 4:
                    manager.CreateGoal();
                    break;
                case 5:
                    manager.RecordEvent();
                    break;
                case 6:
                    manager.SaveGoals();
                    break;
                case 7:
                    manager.LoadGoals();
                    break;
                case 8:
                    return;
            }
        }
    }
}