namespace Practice03.Task05;

class Program
{
    static void Main(string[] args)
    {
        Book boook1 = new Book();
        Book boook2 = new Book("Idiot","Dostoevsky");
        Book boook3 = new Book("МЫ");
        Book boook4 = new Book("Му-му","Тургенев", 2025 );
        Console.WriteLine($"{boook1.author}, {boook1.title}, {boook1.year}");
        Console.WriteLine($"{boook2.author}, {boook2.title},  {boook2.year}");
        Console.WriteLine($"{boook3.author}, {boook3.title},  {boook3.year}");
        Console.WriteLine($"{boook4.author}, {boook4.title},  {boook4.year}");
    }
}