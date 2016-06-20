using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int numToGuess = randomNumber.Next(1, 20);
            Console.WriteLine("Number Guessing game!");
            Console.WriteLine("Pick a number between 1 and 20");
            Console.WriteLine("Enter your guess!");
            var guess = Convert.ToInt32(Console.ReadLine());
            do {
                if (guess != numToGuess)
                {
                    if (guess > numToGuess)
                    {
                        Console.WriteLine("Lower!");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Higher!");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }while (guess != numToGuess);
            Console.WriteLine("Congratulations you have guessed that the numnber was " + numToGuess);
        }
    }
}