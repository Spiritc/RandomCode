using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// Products class
        /// </summary>

        public string Name
        {
            get => this.name; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception ex = new ArgumentException("Name cannon be empty");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get => this.price; set
            {
                if (value < 0)
                {
                    Exception ex = new ArgumentException("Money cannon be negative");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
