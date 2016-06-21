using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsAndProperties
{
    class Car : Vehicle
    {
        private static int carTotal = 0;

        //Car construster that takes the properties
        //public Car()
        //{
        //    //this.name = name;
        //    //this.model = model;
        //    //this.price = price;
        //    //sold = false;
        //    //static carTotal++;
        //}

        //vehicles in stock method
        public static void carStock()
        {
            Console.WriteLine("We currently have {0} cars in stock", Car.carTotal);
        }

        //Sell vehicle method
        public void sellCar()
        {
            this.sold = true;
            carTotal--;
        }
    }
}
