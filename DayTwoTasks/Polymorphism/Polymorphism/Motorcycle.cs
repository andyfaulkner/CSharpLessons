using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Motorcycle : Vehicle
    {
        public override int numbberOfWheels()
        {
            wheels = 2;
            return wheels;
        }
    }
}
