using Foundation2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Product cake = new Product("Cake", 1, 1.25f, 3);
        Product television = new Product("Television", 2, 1200f, 1);
        Product chip = new Product("Chip", 3, 1f, 10);
        Product shirt = new Product("Shirt", 4, 12.30f, 2);
        Product pants = new Product("Pants", 5, 11.25f, 1);

        Address address = new Address("913 Kildeer Ct", "Zionsville", "IN", "United States");

        Customer customer = new Customer("Greg Smothers", address);

        Order order1 = new Order(customer);
        order1.AddProduct(cake);
        order1.AddProduct(television);
        order1.AddProduct(chip);

        Order order2 = new Order(customer);
        order2.AddProduct(shirt);
        order2.AddProduct(pants);

        Console.WriteLine("-- New Order --\n");
        order1.PrintShippingLabel();
        Console.WriteLine();
        order1.PrintPackingLabel();
        Console.WriteLine($"\nTotal: ${order1.GetTotal()}\n");

        Console.WriteLine("-- New Order --\n");
        order2.PrintShippingLabel();
        Console.WriteLine();
        order2.PrintPackingLabel();
        Console.WriteLine($"\nTotal: ${order2.GetTotal()}\n");
    }
}