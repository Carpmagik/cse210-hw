using System.Collections.Generic;

namespace ProductOrderingSystem
{
    public class Order
    {
        private List<Product> products = new List<Product>();
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double CalculateTotal()
        {
            double total = 0;

            foreach (Product p in products)
            {
                total += p.GetTotalCost();
            }

            if (customer.LivesInUSA())
            {
                total += 5;
            }
            else
            {
                total += 35;
            }

            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";

            foreach (Product p in products)
            {
                label += p.GetName() + " (" + p.GetProductId() + ")\n";
            }

            return label;
        }

        public string GetShippingLabel()
        {
            return "Shipping Label:\n" +
                   customer.GetName() + "\n" +
                   customer.GetAddress().GetFullAddress();
        }
    }
}