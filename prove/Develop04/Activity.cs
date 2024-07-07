﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class Activity
    {
        private string _name;
        private string _description;
        protected int _duration;

        public Activity(string name, string description) 
        { 
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description);
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            _duration = int.Parse( Console.ReadLine() );
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage() 
        {
            Console.WriteLine("\nWell done!\n");
            ShowSpinner(2);
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(3);
            Console.Clear();
        }

        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }

        public void ShowCountDown(int seconds) 
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}
