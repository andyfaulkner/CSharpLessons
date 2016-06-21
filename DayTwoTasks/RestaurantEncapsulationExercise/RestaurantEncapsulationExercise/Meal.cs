using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercise
{
    class Meal
    {
        //Meal varibles
        public string name;
        public decimal price;
        public decimal cost;

        //meal constructer
        public void addMeal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
        }

        //cook the meal
        public static void cookMeal(Meal meal)
        {
            Console.WriteLine("The meal {0} has been cooked.", meal.name);
        }
    }
}
