namespace DesignPatterns.SingletonPattern.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageSize { get; set; }

        public Book(int id, string name, string author, int pageSize)
        {
            Id = id;
            Name = name;
            Author = author;
            PageSize = pageSize;
        }
    }
}
