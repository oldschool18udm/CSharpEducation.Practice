namespace Practice03.Task10;

class Program
{
    public static void MarkName(Automobile a)
    {
        Console.WriteLine(a.mark);
    }
    static void Main(string[] args)
    {
        Automobile a = new Automobile();
        a.mark= "BMW";
        Console.WriteLine(a.mark);
        MarkName(a);
    }
}