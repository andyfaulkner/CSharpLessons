using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the balance to zero
            decimal balance = 0;

            //add some meals data
            Meal steak = new Meal();
            steak.addMeal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);

            //Order 1 data
            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            Accounting.processOrderValue(steak);

            //Order 2 data
            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            Accounting.processOrderValue(pumpkinRisotto);

            //Order 3 data
            Order order3 = new Order();
            order3.takeOrder(fajitas);
            Meal.cookMeal(fajitas);
            Accounting.processOrderValue(fajitas);
            
            //get balance from accounting
            balance = Accounting.getRestaurantBalance();

            //print out the balance of what the restaurant made tonight
            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);
        }
    }
}