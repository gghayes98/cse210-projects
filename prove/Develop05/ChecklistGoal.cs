using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Develop05
{
    internal class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }
        public ChecklistGoal(string name, string description, int points, int bonus, int amountCompleted, int target) : base(name, description, points)
        {
            _amountCompleted = amountCompleted;
            _target = target;
            _bonus = bonus;
        }

        public int GetBonus()
        { return _bonus; }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetails()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) - Currently completed: {_amountCompleted}/{_target}";
        }

        public override string Serialize()
        {
            return $"ChecklistGoal~{_shortName}~{_description}~{_points}~{_bonus}~{_amountCompleted}~{_target}";
        }
    }
}
