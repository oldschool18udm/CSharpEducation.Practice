namespace Practice03.Task06;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.x = 0;
        p1.y = 3;
        Point p2 = new Point();
        p2.x = 4;   
        p2.y = 0;
        Console.WriteLine(p1.Distance(p2));
        Console.WriteLine(p2.Distance(p1));
    }
}