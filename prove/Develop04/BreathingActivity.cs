using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }
        public void Run()
        {
            DisplayStartingMessage();

            int remaningTime = _duration;
            while (remaningTime > 0) 
            {
                Console.Write("\nBreathe in... ");
                ShowCountDown(3);
                remaningTime -= 3;

                if (remaningTime <= 0) break;

                Console.Write("\nBreathe out... ");
                ShowCountDown(3);
                remaningTime -= 3;
                Console.WriteLine();
            }
            DisplayEndingMessage();
        }
    }
}
