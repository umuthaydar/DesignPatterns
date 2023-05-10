using DesignPatterns.SingletonPattern.Models;

namespace DesignPatterns.SingletonPattern
{
    public class LibrarySystem
    {
        private static LibrarySystem instance;
        private List<Book> books;

        private LibrarySystem() 
        {
            books = new List<Book>();
        }

        public static LibrarySystem GetInstance() 
        {
            if (instance == null)
            {
                Console.WriteLine("Created Instance");
                instance = new LibrarySystem();
            }

            return instance; 
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Id: " + book.Id + ", Name: " + book.Name + ", Author: " + book.Author + ", Page Size: " + book.PageSize);
        }
    }
}
