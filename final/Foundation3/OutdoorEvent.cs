using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation3
{
    internal class OutdoorEvent : Event
    {
        private string _weather;

        public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
        {
            _weather = weather;
        }

        public override string GetFullDetails()
        { return $"\n{GetStandardDetails()}\nOutdoor Event\nWeather: {_weather}"; }

        public override string GetShortDetails()
        { return $"\nOutdoor Event - {_title}\nDate: {_date}"; }
    }
}