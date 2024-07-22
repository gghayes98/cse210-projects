using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    internal class App
    {
        List<Activity> _activities;

        public App()
        {
            _activities = new List<Activity>();
        }

        public void Run()
        {
            RunningActivity running = new RunningActivity("03 Nov 2022", 30, 3);
            _activities.Add(running);
            CyclingActivity cycling = new CyclingActivity("21 Nov 2023", 90, 18);
            _activities.Add(cycling);
            SwimmingActivity swimming = new SwimmingActivity("12 Apr 2023", 60, 52);
            _activities.Add(swimming);

            PrintSummaries();
        }

        public void PrintSummaries()
        {
            foreach (var  activity in _activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
