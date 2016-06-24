using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryAssessment
{
    public partial class Form1 : Form
    {
        //varibles for use in the form
        List<Book> booksList = new List<Book>();
        private static int bookNumber = 0;

        public Form1()
        {
            InitializeComponent();

            //initial code to initialise the data and list ready for the application

            //create some books for the program to use
            Book book1 = new Book("Ready Player One", "Ernest Cline",
                "It's the year 2044, and the real world has become an ugly place. We're out of oil. We've wrecked the climate. Famine, poverty, and disease are widespread.",
                "9780307887443");
            Book book2 = new Book("JavaScript & JQuery: Interactive Front-end Web Development", "Jon Duckett",
                "This full–color book adopts a visual approach to teaching JavaScript & jQuery, showing you how to make web pages more interactive and interfaces more intuitive through the use of inspiring code examples, infographics, and photography.",
                "9781118871652");

            //Add the books to the list
            booksList.Add(book1);
            booksList.Add(book2);

            //display the first book to the screen
            displayBook(booksList);
        }

        //method to go to the next book with testing to stop it going out of range
        private void buttonNextBook_Click(object sender, EventArgs e)
        {
            if(bookNumber <= (booksList.Count - 2))
            {
                bookNumber++;
                displayBook(booksList);
            }
            else
            {
                bookNumber = 0;
                displayBook(booksList);
            }
        }

        //method to go to the previous book with testing to stop it going out of range
        private void buttonPreviousBook_Click(object sender, EventArgs e)
        {
            if (bookNumber > 0)
            {
                bookNumber--;
                displayBook(booksList);
            }
            else
            {
                bookNumber = (booksList.Count - 1);
                displayBook(booksList);
            }
        }

        //method to add a book
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string titleToAdd = textBoxTitle.Text;
            string authorToAdd = textBoxAuthor.Text;
            string isbnToAdd = textBoxISBN.Text;
            string sysnopsisToAdd = richTextBoxSynopsis.Text;
            Book addBook = new Book(titleToAdd, authorToAdd, sysnopsisToAdd, isbnToAdd);
            booksList.Add(addBook);
        }

        //method to delete a book
        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            booksList.Remove(booksList[bookNumber]);
        }

    //method for displaying the books to the form
    private void displayBook(List<Book> booksList)
    {
            textBoxTitle.Text = booksList[bookNumber].title;
            textBoxAuthor.Text = booksList[bookNumber].author;
            textBoxISBN.Text = booksList[bookNumber].isbn;
            richTextBoxSynopsis.Text = booksList[bookNumber].synopsis;
        }
    }
}
