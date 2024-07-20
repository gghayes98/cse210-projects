using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation2
{
    internal class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool IsInUS()
        { return _address.IsInUS(); }

        public string GetInfo()
        { return $"{_name} - {_address.GetFullAddress()}"; }
    }
}
