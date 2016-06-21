using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercise
{
    class Accounting
    {
        //varible to store the balance
        private static decimal restaurantBalance = 0;

        //method to keep a track of how much the restaurant is making
        public static void processOrderValue(Meal meal)
        {
            restaurantBalance += (meal.price - meal.cost);
        }

        //method to return the balance at the end of the day
        public static decimal getRestaurantBalance()
        {
            return restaurantBalance;
        }
    }
}
