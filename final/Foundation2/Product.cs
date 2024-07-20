using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation2
{
    internal class Product
    {
        private string _name;
        private int _id;
        private float _price;
        private int _quantity;

        public Product(string name, int id, float price, int quantity)
        {
            _name = name;
            _id = id;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        { return _name; }

        public int GetID()
        { return _id; }

        public float GetTotal()
        { return _price * _quantity; }
    }
}
