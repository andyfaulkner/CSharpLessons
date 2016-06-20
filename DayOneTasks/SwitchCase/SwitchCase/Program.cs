using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standing for the US Presidency is: \nHilary Clinton \nBernie Sanders \nAmerican Hitler");
            Console.WriteLine("Who do you think will win? Enter first name, surname or full name");
            string nameOfChoice = (Console.ReadLine()).ToLower();

            //Switch statement to assess the user input
            switch (nameOfChoice)
            {
                case "hilary clinton": 
                case "hilary":
                case "clinton":
                    Console.WriteLine("Good choice");
                    break;
                case "bernie sanders":
                case "bernie":
                case "sanders":
                    Console.WriteLine("Brilliant choice");
                    break;
                case "american hitler":
                case "american":
                case "hitler":
                    Console.WriteLine("We don't have enough bunkers to protect ourselves from nuclear fallout");
                    break;
                default:
                    Console.WriteLine("Not a vlaid name");
                    break;
            }
        }
    }
}
