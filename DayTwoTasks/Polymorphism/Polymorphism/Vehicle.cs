using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Vehicle
    {
        public int wheels = 0;

        public virtual int numbberOfWheels()
        {
            wheels = 0;
            return wheels;
        }
    }
}
