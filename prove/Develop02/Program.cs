using Develop02;
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> _prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "What did I learn today?",
            "When did I feel the spirit today?",
            "How did I serve someone today?",
            "How was I served today?",
            "What did I not do so well today and how can I do better tomorrow?"
        };

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var rand = new Random();
                    string _prompt = _prompts[rand.Next(_prompts.Count)];
                    journal.AddEntry(_prompt);
                    break;
                case "2":
                    journal.DisplayAll();
                    Console.WriteLine();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.Save(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.Load(loadFile);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}