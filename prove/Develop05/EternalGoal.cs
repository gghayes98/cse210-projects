using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Develop05
{
    internal class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points) { }

        public override void RecordEvent()
        { return; }

        public override bool IsComplete()
        { return false; }

        public override string GetDetails()
        {
            return $"[ ] {_shortName} ({_description})";
        }

        public override string Serialize()
        {
            return $"EternalGoal~{_shortName}~{_description}~{_points}";
        }
    }
}
