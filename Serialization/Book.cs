using System;

namespace Serialization
{
    public class Book
    {
        private String title;
        private int pages;

        public Book()
        {
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }

        public override string ToString()
        {
            return title + "  " + pages;
        }
    }
}
