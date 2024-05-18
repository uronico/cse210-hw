using System;
using System.Collections.Generic;
using System.Linq;


public abstract class Activity
{
        private string _name;
        private string _description;
        public int _duration;

        public void StartActivity(string name, string description)
        {
            _name = name;
            _description = description;

            Console.WriteLine($"Welcome to the {_name} activity.\n{_description}");
            Console.WriteLine();
            Console.Write("Please enter the duration in seconds: ");
            _duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nGet ready to begin!");
            ShowSpinner();
            Console.WriteLine();
        }

        public void EndActivity()
        {
            Console.WriteLine("\nGreat job! You have completed the " +_name + " activity. It lasted for " + _duration + " seconds.\n");
            ShowSpinner();
            Console.WriteLine("Thank you for using our app!");
            ShowSpinner();
        }

        public void ShowSpinner()
        {

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(10);

            int i = 0; 

            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                i++;

                if (i >= animationStrings.Count)
                {
                    i=0;
                }
            }
        }

        public void ShowCountDown(int seconds)
        {
            Console.Write("\nCountdown: ");
            for (int i = seconds; i > 0; i--)
            {
                Console.Write("{0} ", i);
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
}

