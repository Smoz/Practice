using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // To use our Book class we need to
            // create an instance of it
            // We also need to pass in the title
            // and author of the book

            Book book = new Book("Harry Potter", "J.K. Rowling");

            Console.WriteLine(book.GetTitle() + " by " + book.GetAuthor());
            Console.ReadKey();
        }
    }
}
