using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation3
{
    internal class ReceptionEvent : Event
    {
        private string _email;

        public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
        {
            _email = email;
        }

        public override string GetFullDetails()
        { return $"\n{GetStandardDetails()}\nReception Event - RSVP: {_email}"; }

        public override string GetShortDetails()
        { return $"\nReception Event - {_title}\nDate: {_date}"; }
    }
}
