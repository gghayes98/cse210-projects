using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation3
{
    internal class LectureEvent : Event
    {
        private string _speaker;
        private int _capacity;

        public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string GetFullDetails()
        { return $"\n{GetStandardDetails()}\nLecture Event - Speaker: {_speaker} - Capacity: {_capacity}"; }

        public override string GetShortDetails()
        { return $"\nLecture Event - {_title}\nDate: {_date}"; }
    }
}
