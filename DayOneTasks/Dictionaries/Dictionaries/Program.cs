using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the dictionary
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();

            //add data into the dictionary
            codingLanguages.Add("C#", "Object orientated programming language");
            codingLanguages.Add("Javascript", "Scripting language used primarley to create interactivity on websites.");
            codingLanguages.Add("Java", "Object orientated language used to build applications");

            string languageSearch;

            Console.WriteLine("Welcome to the coding language list");
            Console.WriteLine("Press L to list the languages\nPress K to search the dictionary for a key\n Press D to search the dictionary for a description\nPress C to count the length of the list\nPress X to exit");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                switch (userInput)
                {
                    case 'C':
                        int languageCount = codingLanguages.Count();
                        Console.WriteLine("There are {0} languages in the dictionary", languageCount);
                        break;
                    case 'L':
                        foreach (KeyValuePair<string, string> lang in codingLanguages)
                        {
                            Console.WriteLine(lang.Key + "\n" + lang.Value);
                        }
                        break;
                    case 'K':
                        Console.WriteLine("Enter the key that you wish to search for: ");
                        languageSearch = Console.ReadLine();
                        if (codingLanguages.ContainsKey(languageSearch))
                        {
                            Console.WriteLine(languageSearch + " is in the dictionary");
                        }
                        else
                        {
                            Console.WriteLine("The Key is not in the dictionary");
                        }
                        break;
                    case 'D':
                        Console.WriteLine("Enter the descrition that you want to search for: ");
                        languageSearch = Console.ReadLine();
                        if (codingLanguages.ContainsValue(languageSearch))
                        {
                            Console.WriteLine(languageSearch + " is in the dictionary");
                        }
                        else
                        {
                            Console.WriteLine("The description is not in the dictionary");
                        }
                        break;
                }
                Console.WriteLine("Press L to list the languages\nPress K to search the dictionary for a key\n Press D to search the dictionary for a description\nPress C to count the length of the list\nPress X to exit");
                userInput = Convert.ToChar(Console.ReadLine().ToUpper());
            } while (userInput != 'X');

        }
    }
}
