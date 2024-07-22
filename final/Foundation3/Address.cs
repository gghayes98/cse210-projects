using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation3
{
    internal class Address
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _country;

        public Address(string streetAddress, string city, string state, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _state = state;
            _country = country;
        }

        public string GetAddressString()
        { return $"{_streetAddress} {_city}, {_state}, {_country}"; }
    }
}
