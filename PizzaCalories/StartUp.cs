using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] pizzaName = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = pizzaName[1];

            Pizza pizza = new Pizza(name);


            while (true)
            {
                input = Console.ReadLine();
                string[] inputSplited = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (inputSplited.Length == 4 && inputSplited[0] == "Dough")
                {
                    Dough dough = new Dough(inputSplited[1], inputSplited[2], double.Parse(inputSplited[3]));
                    pizza.Dough = dough;
                }
                if (inputSplited.Length == 3 && inputSplited[0] == "Topping")
                {
                    Topping topping = new Topping(inputSplited[1], double.Parse(inputSplited[2]));
                    pizza.AddTopping(topping);
                }
                if (inputSplited.Length == 1 && inputSplited[0] == "END")
                {
                    Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
                    break;
                }

            }
            
        }
    }
}

//A Pizza is made of dough and different toppings.You should model a class Pizza, which should have a name, 
//    dough and toppings as fields.Every type of ingredient should have its own class. 
//Every ingredient has different properties: the dough can be white or wholegrain and in addition, it can be crispy, chewy or homemade.
//    The toppings can be of type meat, veggies, cheese or sauce.Every ingredient should have a weight
//    in grams and a method for calculating its calories according to its type.Calories per gram are calculated through modifiers.
//    Every ingredient has 2 calories per gram as a base and a modifier that gives the exact calories. 
//    For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough, 
//    weighting 100 grams will have 100 * 1.5 * 1.1 = 330.00 total calories.
//Your job is to model the classes in such a way that they are properly encapsulated and to provide 
//    a public method for every pizza that calculates its calories according to the ingredients it has.
