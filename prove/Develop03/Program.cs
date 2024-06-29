// Added a list that can be expanded as needed or desired to have more scriptures to study

using Develop03;
using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            // Add more scriptures as needed
        };

        // Pick a random scripture
        Random rand = new Random();
        int randomIndex = rand.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[randomIndex];

        Console.WriteLine($"{selectedScripture.GetReference().GetText()} {selectedScripture.GetText()}");
        Console.WriteLine("\nPlease enter to continue or type 'quit' to finish:");

        string choice = Console.ReadLine();
        // Loop until user types 'quit' removing words everytime they don't
        while (choice != "quit")
        {
            selectedScripture.HideRandomWords(3);
            Console.Clear();

            Console.WriteLine($"{selectedScripture.GetReference().GetText()} {selectedScripture.GetText()}");
            Console.WriteLine("\nPlease enter to continue or type 'quit' to finish:");

            choice = Console.ReadLine();
        }
    }
}