using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;
        private List<string> _usedPrompts;

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string> {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
            _usedPrompts = new List<string>();
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            int duration = _duration;
            while (startTime.AddSeconds(_duration) > DateTime.Now) 
            {
                Console.Write("> ");
                Console.ReadLine();
                _count++;
            }
            Console.WriteLine($"You listed {_count} items!");
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            if (_prompts.Count == 0)
            {
                _prompts.AddRange(_usedPrompts);
                _usedPrompts.Clear();
            }
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            string prompt = _prompts[index];
            _prompts.RemoveAt(index);
            _usedPrompts.Add(prompt);
            return prompt;
        }
    }
}
