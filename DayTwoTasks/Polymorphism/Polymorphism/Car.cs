using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car : Vehicle
    {
        public new int numbberOfWheels()
        {
            wheels = 4;
            return wheels;
        }
    }
}
