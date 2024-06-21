using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustomObjects
{
    internal class Program
    {
        /*
        Question 5: List of Custom Objects
        Define a class Book with properties
        Title and Author.
        Create a list of Book objects with at
        least three books.
        Print all books in the list.
        */
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
             new Book("Far From The End", "Lilian Chidiogo Ezejelue"),
             new Book("Purple Hibiscus", "Chimanda Ngozi Adichie"),
             new Book("Born On A Tuesday", "Elnathan John"),
            };

            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}\n Author: {book.Author}\n");
            }
        }
    }
}
