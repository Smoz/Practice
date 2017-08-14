using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class Book
    {
        // Private instance variables

        private string title;
        private string author;
        private int pages;
        private int wordCount;

        // Public 'safe' constructor

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        // Public constructor

        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        // Method to get the title of the book

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }

    }
}
