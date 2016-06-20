using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Riddles using While and Do While loops");

            //riddle one
            Console.WriteLine("First riddle: ");
            Console.WriteLine("What gets wetter and wetter the more it dries?");
            string userGuess = "towel";
            var userInput = Console.ReadLine().ToLower();
            while (userGuess != userInput)
            {
                Console.WriteLine("Your guess isn't correct! Try again!");
                userInput = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Correct");

            //riddle two
            Console.WriteLine("What can travel around the world while staying in a corner?");
            userGuess = "stamp";
            userInput = Console.ReadLine().ToLower();
            do
            {
                Console.WriteLine("Your guess isn't correct! Try again!");
                userInput = Console.ReadLine().ToLower();
            } while (userGuess != userInput);

            Console.WriteLine("Correct");
        }
    }
}
