using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        public string Name
        {
            get => name; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception ex = new ArgumentException("Name cannon be empty");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money; set
            {
                if (value < 0)
                {
                    Exception ex = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                money = value;
            }
        }
        internal List<Product> Products { get => products; set => products = value; }

        public void Add(Product product)
        {
            decimal cost = product.Price;
            string productName = product.Name;

            if (this.Money < cost)
            {
                Console.WriteLine($"{this.Name} can't afford {productName}");
            }
            else
            {
                this.Products.Add(product);
                Console.WriteLine($"{this.Name} bought {productName}");
                this.Money -= cost;
            }
        }

        public override string ToString()
        {
            string result = "";

            if (products.Count == 0)
            {
                result = $"{this.Name} - Nothing bought";
            }
            else
            {
                result = $"{this.Name} - {string.Join(", ", this.products)}";
            }

            return result;
        }
    }
}
