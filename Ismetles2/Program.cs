namespace Ismetles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            book1.PageCountGetSet();
            Console.WriteLine(book1);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee",-10);
            Console.WriteLine(book2);

        }
    }
}
