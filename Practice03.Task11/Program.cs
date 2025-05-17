namespace Practice03.Task11;

class Program
{
    public static string BookInfo(Book book)
    {
        return $"{book.Title} - {book.Author}";
    }
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Author = "Gogol";
        book.Title = "Viy";
        Console.WriteLine(BookInfo(book));
    }
}