using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation2
{
    internal class Order
    {
        private Customer _customer;
        private List<Product> _products;
        private float _total;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
            _total = 0;
        }

        public void AddProduct(Product product) 
        { _products.Add(product); }

        private void ComputeTotal()
        {
            foreach (Product product in _products) 
            {
                _total += product.GetTotal();
            }
            AddShipping();
        }

        private void AddShipping()
        {
            if (_customer.IsInUS())
                _total += 5;
            else _total += 35;
        }

        public void PrintPackingLabel()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine($"{product.GetName()} - {product.GetID()}");
            }
        }

        public void PrintShippingLabel()
        {
            Console.WriteLine(_customer.GetInfo());
        }

        public float GetTotal()
        {
            ComputeTotal();
            return _total;
        }
    }
}
