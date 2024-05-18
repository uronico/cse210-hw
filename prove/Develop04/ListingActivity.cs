using System;
using System.Collections.Generic;
using System.Linq;

public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public void StartActivity()
        {
            base.StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine("List as many responses you can do to the following prompt:");
            
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine("--- " + prompt + " ---");
            ShowSpinner();
            Console.WriteLine("\nGet ready to start listing!");
            ShowCountDown(3);
            Console.WriteLine("\nStart listing!");
            DateTime start = DateTime.Now;
            int itemCount = 0;
            while (DateTime.Now - start < TimeSpan.FromSeconds(_duration))
            {
                string item = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(item))
                break;

                itemCount++;
            }
            Console.WriteLine($"\nYou listed {itemCount} items!");
            base.EndActivity();
        }
    }