namespace Practice03.Task05;

public class Book
{
    public string title;
    public string author;
    public int year;

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    public Book() : this("None", "Null", 0)
    {
    }

    public Book(string title) : this(title, "Null", 0)
    {
    }

    public Book(string title, string author) : this(title, author, 0)
    {
    }
}