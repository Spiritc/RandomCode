using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string inputPeople = Console.ReadLine();
            string[] inputCutPeople = inputPeople
                .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            string inputProducts = Console.ReadLine();
            string[] inputCutProduct = inputProducts
                .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < inputCutPeople.Length; i += 2)
            {
                string name = inputCutPeople[i];
                decimal money = decimal.Parse(inputCutPeople[i + 1]);

                Person person = new Person(name, money);
                persons.Add(person);

            }

            for (int i = 0; i < inputCutProduct.Length; i += 2)
            {
                string name = inputCutProduct[i];
                decimal cost = decimal.Parse(inputCutProduct[i + 1]);

                Product product = new Product(name, cost);
                products.Add(product);

            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = inputArgs[0];
                string productName = inputArgs[1];

                Product product = products.First(p => p.Name == productName);

                persons.First(f => f.Name == personName).Add(product);

                input = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
