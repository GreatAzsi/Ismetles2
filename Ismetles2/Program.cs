namespace Ismetles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Homeland", "R.A Salvatore");
            book1.PageCountSet(590);
            Book.Describe(book1);
            Book book2 = new Book("Exile", "R.A Salvatore",598);
            Book.Describe(book2);
            Book book3 = new Book("Sojurn", "R.A Salvatore", 620);
            Book.Describe(book3);

            Console.WriteLine(Book.TotalBooks);
           
            book1.IsAvailable = true;
            Console.WriteLine(Book.Borrow(book1));
            Console.WriteLine(Book.Borrow(book1));
            Book.Return(book1);
            Console.WriteLine(Book.Borrow(book1));

            Library library = new Library("My Library");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            Book book4 = new Book("The Crystal Shard", "R.A Salvatore", 777);
            library.AddBook(book4);
            Book book5 = new Book("Streams Of Silver", "R.A Salvatore", 632);
            Book book6 = new Book("The Halfling’s Gem", "R.A Salvatore", 628);
            library.AddBook(book5);
            library.AddBook(book6);


        }
    }
}
