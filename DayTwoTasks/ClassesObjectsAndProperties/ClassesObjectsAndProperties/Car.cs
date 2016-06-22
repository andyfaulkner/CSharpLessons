using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsAndProperties
{
    public class Car : Vehicle
    {
        public static int carTotal = 0;

        //Car construster that takes the properties
        public Car(string nm, string mod, int pr) : base(nm, mod, pr)
        {
            carTotal++;
        }

        //cars in stock method
        public static void carStock()
        {
            Console.WriteLine("We currently have {0} cars in stock", Car.carTotal);
        }
    }
}
