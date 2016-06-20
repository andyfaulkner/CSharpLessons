using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarfs = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            for(int i = 0; i < sevenDwarfs.Length; i++)
            {
                Console.WriteLine(sevenDwarfs[i] + ", your roast beef is ready!");
            }
            foreach (string dwarf in sevenDwarfs)
            {
                Console.WriteLine(dwarf + ", your cocoa is ready!");
            }
        }
    }
}
