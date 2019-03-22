using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private double weightInGrams;
        private double calories;
        private static double meat = 1.2;
        private static double veggies = 0.8;
        private static double cheese = 1.1;
        private static double sauce = 0.9;


        public Topping(string name, double weight)
        {
            this.ToppingType = name;
            this.WeightGram = weight;

            switch (name)
            {
                case "Meat":
                    this.calories = this.WeightGram * 2 * meat;
                    break;
                case "Veggies":
                    this.calories = this.WeightGram * 2 * veggies;
                    break;
                case "Cheese":
                    this.calories = this.WeightGram * 2 * cheese;
                    break;
                case "Sauce":
                    this.calories = this.WeightGram * 2 * sauce;
                    break;
                default:
                    break;
            }

        }

        public string ToppingType
        {
            get => toppingType;
            set
            {
                if (value == "Meat"
                    || value == "Veggies"
                    || value == "Cheese"
                    || value == "Sauce")
                {
                    toppingType = value;

                }
                else
                {
                    Exception ex = new Exception($"Cannot place {value} on top of your pizza.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }


        public double WeightGram
        {
            get => weightInGrams;
            set
            {
                if (value < 1 || value > 50)
                {
                    Exception ex = new Exception($"{this.ToppingType} weight should be in the range [1..50].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);

                }
                weightInGrams = value;
            }
        }

        public double Calories { get => calories; }
    }
}
