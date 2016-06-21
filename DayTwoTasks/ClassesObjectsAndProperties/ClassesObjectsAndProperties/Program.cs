using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsAndProperties
{
    class Program
    {
    
      static void Main(string[] args)
        {
            //create the car list
            List<Vehicle> listOfVehicles = new List<Vehicle>();

            //instigate 3 objects
            Car car1 = new Car("Audi", "TT", 12000);
            Car car2 = new Car("Honda", "S2000", 15000);
            Car car3 = new Car("Toyota", "Landcruiser", 45000);

            //add the cars to the list
            listOfVehicles.Add(car1);
            listOfVehicles.Add(car2);
            listOfVehicles.Add(car3);

            //output the cars to the console
            Car.carStock();
            car1.printCarData();
            Car.stockValue(listOfVehicles);
            car2.sellCar();
            car2.printCarData();
            car3.printCarData();
            Car.carStock();
            Car.stockValue(listOfVehicles);

            car1.printVehicleData();
        }
    }
}
