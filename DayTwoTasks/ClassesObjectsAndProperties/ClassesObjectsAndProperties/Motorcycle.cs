using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsAndProperties
{
    public class Motorcycle : Vehicle
    {
        private static int bikeTotal = 0;

        //bike construster that takes the properties
        public Motorcycle(string nm, string mod, int pr) : base (nm, mod, pr)
        {
            bikeTotal++;
        }
    }
}
