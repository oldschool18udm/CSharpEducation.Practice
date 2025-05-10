namespace Practice03.Task04;

class Program
{
    static void Main(string[] args)
    {
        Book boook1 = new Book();
        Book boook2 = new Book("Idiot","Dostoevsky");
        Console.WriteLine($"{boook1.author}, {boook1.title}");
        Console.WriteLine($"{boook2.author}, {boook2.title}");
    }
}