using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibraryAssessment
{
    public class Book
    {
        //all varibles used to descibe the book
        public string title;
        public string author;
        public string synopsis;
        public string isbn;

        //varible for total number of books
        public static int totalNumberOfBooks = 0;

        //Book constructer
        public Book(string _title, string _author, string _synopsis, string _isbn)
        {
            this.title = _title;
            this.author = _author;
            this.synopsis = _synopsis;
            this.isbn = _isbn;
            totalNumberOfBooks++;
        }
    }
}
