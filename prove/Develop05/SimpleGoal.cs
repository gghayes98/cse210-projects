using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    internal class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points) 
        { _isComplete = false; }

        public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
        { _isComplete = isComplete; }

        public override void RecordEvent()
        { 
            _isComplete = true;
        }

        public override bool IsComplete()
        { return _isComplete; }

        public override string GetDetails()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
        }

        public override string Serialize()
        {
            return $"SimpleGoal~{_shortName}~{_description}~{_points}~{_isComplete}";
        }
    }
}
