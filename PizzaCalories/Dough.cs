using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double calories;
        private const double baseCalories = 2.0;
        private const double white = 1.5;
        private const double wholegrain = 1.0;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;

            if (flourType == "White")
            {
                switch (bakingTechnique)
                {
                    case "Crispy":
                        this.calories = (baseCalories * weight) * crispy * white;
                        break;
                    case "Chewy":
                        this.calories = (baseCalories * weight) * chewy * white;
                        break;
                    case "Homemade":
                        this.calories = (baseCalories * weight) * homemade * white;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (bakingTechnique)
                {
                    case "Crispy":
                        this.calories = (baseCalories * weight) * crispy * wholegrain;
                        break;
                    case "Chewy":
                        this.calories = (baseCalories * weight) * chewy * wholegrain;
                        break;
                    case "Homemade":
                        this.calories = (baseCalories * weight) * homemade * wholegrain;
                        break;
                    default:
                        break;
                }
            }

        }

        public string FlourType
        {
            get => flourType; private set
            {
                if (value == "White" || value == "Wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    InvaliTypeDough();

                }
            }
        }

        private void InvaliTypeDough()
        {
            Exception ex = new ArgumentException("Invalid type of dough.");
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
             
        }

        public string BakingTechnique { get => bakingTechnique; private set => bakingTechnique = value; }
        public double Weight
        {
            get => weight; private set
            {
                if (value < 0d || value > 200d)
                {
                    InvalideWeight();
                }
                weight = value;
            }
        }

        private void InvalideWeight()
        {
            Exception ex = new ArgumentException("Dough weight should be in the range [1..200].");
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }

        public double Calories { get => calories; }
        
    }
}
