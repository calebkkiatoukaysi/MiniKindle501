namespace MiniKindle501
{
    public class Library
    {
        public List<Book> library { get; set; }

        public Library(List<Book> books)
        {
            library = books ?? new List<Book>();
        }
    }
}