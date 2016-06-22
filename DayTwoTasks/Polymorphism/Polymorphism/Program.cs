using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare an object of each type
            Car car1 = new Car();
            Motorcycle bike1 = new Motorcycle();

            //using new and override to change the virtual method and print the number of wheels to the screen
            Console.WriteLine("A car has {0} wheels", car1.numbberOfWheels());
            Console.WriteLine("A motorcycle has {0} wheels", bike1.numbberOfWheels());
        }
    }
}
