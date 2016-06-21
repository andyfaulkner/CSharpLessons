using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsAndProperties
{
    //create the vehicle class
    class Vehicle
    {
        //varibles for use in the Vehicle class
        public string name;
        public string model;
        public int price;
        public bool sold;
        private static int vehicleTotal;

        //Car construster that takes the properties
        public Vehicle(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            sold = false;
            vehicleTotal++;
        }

        //print the list of vehicles to the console
        public void printVehicleData()
        {
            Console.WriteLine("We have a {0} {1} which costs £{2}", this.name, this.model, this.price);
            if (sold)
            {
                Console.Write("This car has been sold!\n");
            }
        }

        //Sell vehicle method
        public void sellVehicle()
        {
            this.sold = true;
            vehicleTotal--;
        }

        //vehicles in stock method
        public static void vehicleStock() {
            Console.WriteLine("We currently have {0} cars in stock", Car.carsTotal);
        }

        //Create a value of stock method
        public static void stockValue(List<Vehicle> listOfVehicles)
        {
            int totalValueOfStock = 0;
            foreach (var vehicleList in listOfVehicles)
            {
                if (vehicleList.sold == false)
                {
                    totalValueOfStock += vehicleList.price;
                }
            }
            Console.WriteLine("The total value of stock is {0}", totalValueOfStock);
        }
    }
}
