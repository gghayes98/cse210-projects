using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Develop05
{
    internal class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine($"\nYou have {_score} points.\n");
                Console.WriteLine("Menu Options:\n  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("The goals are:");
            foreach (var goal in _goals)
            {
                Console.WriteLine($"- {goal.GetDetails()}");
            }
        }

        public void CreateGoal()
        {
            Console.Write("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
            string goalType = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            switch(goalType.ToLower())
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accopmlishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }

        public void RecordEvent()
        {
            Console.Write("Enter goal name to record an event: ");
            string name = Console.ReadLine();

            var goal = _goals.FirstOrDefault(g => g.GetName() == name);
            if (goal != null)
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus();
                }
                Console.WriteLine($"Congratulations! You earned {goal.GetPoints()} points!");
            }
            else
            {
                Console.WriteLine("Goal not found.");
            }
        }

        public void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName)) 
            {
                outputFile.WriteLine(_score);
                foreach (var goal in _goals) 
                {
                    outputFile.Write(goal.Serialize());
                }
            }
        }

        public void LoadGoals() 
        {
            _goals.Clear();
            Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);
            lines = lines.Skip(1).ToArray();
            foreach (string line in lines)
            {
                string[] parts = line.Split('~');
                if (parts[0] == "SimpleGoal")
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                else if (parts[0] == "EternalGoal")
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                else if (parts[0] == "ChecklistGoal")
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
    }
}
