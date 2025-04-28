namespace Practice02.Task16;

class Program
{
    static void sign(ref int a)
    {
        a *= -1;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = Convert.ToInt32(Console.ReadLine());
        sign(ref a);
        Console.WriteLine(a);
    }
}