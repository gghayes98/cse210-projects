using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Foundation3
{
    internal class Event
    {
        protected string _title;
        private string _description;
        protected string _date;
        private string _time;
        private Address _address;

        public Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        public string GetStandardDetails()
        { return $"\n{_title} - {_description}\nWhen: {_date} at {_time}\nAddress: {_address.GetAddressString()}"; }

        public virtual string GetFullDetails() { return "ERROR"; }
        public virtual string GetShortDetails() { return "ERROR"; }
    }
}
