namespace Practice02.Task03;

class Program
{
    static void Main(string[] args)
    {
        float a,b,f;
        Console.WriteLine("Enter the A");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the B");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the f");
        f = float.Parse(Console.ReadLine());
        if (a !=0) {Console.WriteLine((a + b - f / a) + f * a * a - (a + b));}
        else
        {
            Console.WriteLine("Error");
        }
        ;

    }
}