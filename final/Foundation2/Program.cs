using System;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address(
                "123 Main St",
                "Denver",
                "Colorado",
                "USA");

            Customer customer1 = new Customer("Joseph Smith", address1);

            Order order1 = new Order(customer1);

            order1.AddProduct(new Product("Keyboard", "P101", 25.00, 2));
            order1.AddProduct(new Product("Mouse", "P102", 15.00, 1));
            order1.AddProduct(new Product("Monitor", "P103", 200.00, 1));

            Address address2 = new Address(
                "456 Queen Street",
                "Toronto",
                "Ontario",
                "Canada");

            Customer customer2 = new Customer("Sarah Jones", address2);

            Order order2 = new Order(customer2);

            order2.AddProduct(new Product("Laptop", "P201", 800.00, 1));
            order2.AddProduct(new Product("Headphones", "P202", 75.00, 2));

            // Order 1
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");

            Console.WriteLine("\n---------------------------------\n");

            // Order 2
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        }
    }
}