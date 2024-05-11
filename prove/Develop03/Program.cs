using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {

        new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge Him, and He will direct thy paths."),
        new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        new Scripture(new Reference("Psalm", 23,4), "Yea, though I walk through the darkest valley of the shadow of death, I will fear no evil, for thou art with me; thy rod and thy staff they comfort me."),
        new Scripture(new Reference("1 Nephi", 3,7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
    
        };
        

            // Choose a random scripture from the library
            Random random = new Random();
            Scripture randomScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide a random word, or type 'quit' to exit: ");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            randomScripture.HideRandomWords(1);
            if (randomScripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. The game is over.");
                break;
            }
        }
    
    }
    
    
}