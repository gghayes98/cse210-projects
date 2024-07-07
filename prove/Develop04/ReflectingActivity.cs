﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;
        private List<string> _usedPrompts;
        private List<string> _usedQuestions;

        public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your left when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") 
        {
            _prompts = new List<string> {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            _questions = new List<string> {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
            _usedPrompts = new List<string>();
            _usedQuestions = new List<string>();
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("\nConsider the following prompt:\n");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write($"You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            int remainingTime = _duration;
            while (remainingTime > 0)
            {
                Console.Write($"> {GetRandomQuestion()} ");
                ShowSpinner(5);
                remainingTime -= 5;
                Console.Write("\n");
            }

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

        public string GetRandomQuestion()
        {
            if (_questions.Count == 0)
            {
                _questions.AddRange(_usedQuestions);
                _usedQuestions.Clear();
            }
            Random random = new Random();
            int index = random.Next(_questions.Count);
            string question = _questions[index];
            _questions.RemoveAt(index);
            _usedQuestions.Add(question);
            return question;
        }
    }
}
