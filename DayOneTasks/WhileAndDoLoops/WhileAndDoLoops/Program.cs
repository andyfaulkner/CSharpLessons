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

            //varible to control guesses
            int numOfGuesses = 0;

            //riddle one
            Console.WriteLine("First riddle: ");
            Console.WriteLine("What gets wetter and wetter the more it dries?");
            bool userGuess = false;
            var userInput = Console.ReadLine().ToLower();
            while (userGuess == false && numOfGuesses < 2)
            {
                numOfGuesses++;
                switch (userInput)
                {
                    case "a towel":
                    case "towel":
                        userGuess = true;
                        Console.WriteLine("Correct");
                        break;
                    default:
                        Console.WriteLine("Your guess isn't correct! Try again!");
                        userInput = Console.ReadLine().ToLower();
                        break;
                }
            }

            

            //riddle two
            numOfGuesses = 0;
            Console.WriteLine("What can travel around the world while staying in a corner?");
            userGuess = false;
            userInput = Console.ReadLine().ToLower();
            while (userGuess == false && numOfGuesses < 2)
            {
                numOfGuesses++;
                switch (userInput)
                {
                    case "a stamp":
                    case "stamp":
                        userGuess = true;
                        Console.WriteLine("Correct");
                        break;
                    default:
                        Console.WriteLine("Your guess isn't correct! Try again!");
                        userInput = Console.ReadLine().ToLower();
                        break;
                }
            }

            

            //riddle three
            numOfGuesses = 0;
            Console.WriteLine("Take off my skin - I won't cry, but you will! What am I?");
            userGuess = false;
            userInput = Console.ReadLine().ToLower();
            while (userGuess == false && numOfGuesses < 2)
            {
                numOfGuesses++;
                switch (userInput)
                {
                    case "an onion":
                    case "onion":
                        userGuess = true;
                        Console.WriteLine("Correct");
                        break;
                    default:
                        Console.WriteLine("Your guess isn't correct! Try again!");
                        userInput = Console.ReadLine().ToLower();
                        break;
                }
            }

            
        }
    }
}
