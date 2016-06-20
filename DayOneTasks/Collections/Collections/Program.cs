using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book program to add and remove books");

            List<string> booksList = new List<string>()
            { "Ready Player One",
                "Bedlam",
                "Rivers of London",
                "London Calling",
                "Who Killed Sherlock Holmes"
            };

            string bookToDelete, bookToAdd;

            Console.WriteLine("Welcome to the book list");
            Console.WriteLine("Press A to add a book, D to delete a book, L to list the books, S to sort the list and X to exit");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                switch (userInput)
                {
                    case 'A':
                        Console.WriteLine("Type the name of the book you would like to add: ");
                        bookToAdd = Console.ReadLine();
                        booksList.Add(bookToAdd);
                        break;
                    case 'D':
                        Console.WriteLine("Type the name of the book you would like to delete: ");
                        bookToDelete = Console.ReadLine();
                        booksList.Remove(bookToDelete);
                        break;
                    case 'L':
                        for(int i = 0; i < booksList.Count; i++)
                        {
                            Console.WriteLine(booksList[i]);
                        }
                        break;
                    case 'S':
                        booksList.Sort();
                        break;
                }
                Console.WriteLine("Press A to add a book, D to delete a book, L to list the books, S to sort the list and X to exit");
                userInput = Convert.ToChar(Console.ReadLine().ToUpper());
            } while (userInput != 'X');
        }
    }
}
