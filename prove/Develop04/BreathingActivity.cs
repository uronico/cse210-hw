using System;
using System.Collections.Generic;
using System.Linq;

public class BreathingActivity : Activity
    {
        public void StartActivity()
        {
            base.StartActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.WriteLine("\nBreathe out...");
            ShowCountDown(3);
            
            int counter = 0;
            while (counter < _duration)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountDown(3);
                Console.WriteLine("\nBreathe out...");
                ShowCountDown(3);
                counter += 6;
            }
            base.EndActivity();
        }
    }