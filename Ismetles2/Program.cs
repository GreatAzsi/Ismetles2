namespace Ismetles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            book1.PageCountSet(200);
            Book.Describe(book1);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee",-10);
            Book.Describe(book2);
            Book book3 = new Book("1984", "George Orwell", 328);
            Book.Describe(book3);

            Console.WriteLine(Book.TotalBooks);
        }
    }
}
