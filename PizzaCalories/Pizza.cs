using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == "" || value.Length > 15)
                {
                    Exception ex = new Exception($"Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public Dough Dough { get => dough; set => dough = value; }
        public List<Topping> Toppings
        {
            get => toppings;
            set
            {
                if (this.Toppings == null)
                {
                    
                    toppings = value;

                }
                else
                {
                    if (IsLessThan10())
                    {
                        
                        toppings = value;

                    }
                    else
                    {
                        
                        Exception ex = new Exception($"Number of toppings should be in range [0..10].");
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);

                    }

                }
            }
        }

        private bool IsLessThan10()
        {
            return this.Toppings.Count < 10 ? true : false;
        }

        public void AddTopping(Topping topping)
        {
            this.Toppings.Add(topping);
        }

        public double GetCalories()
        {
            double doughCal = this.Dough.Calories;
            double toppingsCal = this.Toppings.Sum(s => s.Calories);

            return doughCal + toppingsCal;
        }
    }
}
