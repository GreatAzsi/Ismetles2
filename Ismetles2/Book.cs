using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private int PageCount;
        public bool IsAvailable { get; set; }
        public static int TotalBooks { get; private set; } = 0;

        public int PageCountGetSet() 
        {
            Console.WriteLine("Please get or set the Pagecount of the Book");
            string ans = Console.ReadLine();
            
            if(ans.ToLower() == "get")
            {
                return PageCount;
            }
            else if (ans.ToLower() == "set")
            {
                Console.WriteLine("Enter new page count:");
                int newPageCount = int.Parse(Console.ReadLine());
                if(newPageCount < 0)
                {
                    PageCount = 0;
                    return PageCount;
                }
                else
                {
                    PageCount = newPageCount;
                    return PageCount;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'get' or 'set'.");
                return PageCountGetSet();
            }
        }
        public int PageCountSet(int pageCount)
        {
                if (pageCount < 0)
                {
                    PageCount = 0;
                    return PageCount;
                }
                else
                {
                    PageCount = pageCount;
                    return PageCount;
                }
            }
            
        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = PageCountSet(pageCount);
            TotalBooks++;
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author; 
            PageCount = 0;
            TotalBooks++;
        }

        public static void Describe(Book book)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Page Count: {book.PageCount}");
        }
        public static bool Islong(Book book)
        {
            return book.PageCount > 300;
        }
        public static bool Borrow(Book book)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Return(Book book)
        {
            book.IsAvailable = true;
        }

    }
}
