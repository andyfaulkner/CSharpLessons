using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a multidimensional array
            int[,] userValues = new int[5, 5];

            Random randonNumber = new Random();
            

            //fill the array
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Enter your value for " + i + j + " in the array");
                    userValues[i, j] = randonNumber.Next(1, 10);
                    Console.WriteLine(userValues[i,j]);
                }
            }
            

            int totalNumber = 0;
            
            //add up both columns, the rows and the total of the numbers then print to the screen
            int rowSum = 0;
            int columnSum = 0;
            for (int i = 0; i < 5; i++)
            {
                rowSum = 0;
                for (int j = 0; j < 5; j++)
                {
                    totalNumber += userValues[i, j];
                    rowSum += userValues[i, j];
                }
                Console.WriteLine("line {0} has a sum of {1}", (i + 1).ToString(), rowSum.ToString());
            }
            for (int j = 0; j < 5; j++)
            {
                columnSum = 0;
                for (int i = 0; i < 5; i++)
                {
                    columnSum += userValues[i, j];
                }
                Console.WriteLine("Column {0} has a sum of {1}", (j + 1).ToString(), columnSum.ToString());
            }

            int averageNumber = totalNumber / 25;

            Console.WriteLine("The average of the 25 numbers is: " + averageNumber);
        }
    }
}
