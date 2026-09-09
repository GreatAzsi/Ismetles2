using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles2
{
    public class Library
    {
        public string Name { get; set; }
        private List<Book> Books { get; set; }
        public int BookCount { get { return Books.Count; } }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void PrintAll()
        {
            foreach (Book book in Books)
            {
                Book.Describe(book);
            }
        }
        public Book FindByTitle(string title)
        {
            foreach(Book book in Books)
            {
                    if (book.Title == title)
                    {
                        return book;
                    }
            }
            return null;
        }
    }
    
}
