namespace Practice02.Task08;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a == b || a == c || b == c )
        {
            a += 5;
            b += 5;
            c += 5;
            Console.WriteLine($"{a} {b} {c}");
        }
        else
        {
            Console.WriteLine("Равных нет");
        }
    }
}