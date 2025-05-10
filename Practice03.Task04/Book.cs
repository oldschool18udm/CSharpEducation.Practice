namespace Practice03.Task04;

public class Book
{
    public string title;
    public string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public Book()
    {
        this.title = "None";    
        this.author = "Null";
    }
}