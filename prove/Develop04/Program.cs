using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("\n1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.StartActivity();
                        break;
                    case 2:
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.StartActivity();
                        break;
                    case 3:
                        ListingActivity listing = new ListingActivity();
                        listing.StartActivity();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
}

    
