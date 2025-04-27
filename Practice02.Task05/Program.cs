namespace Practice02.Task05;

class Program
{
    static void Main(string[] args)
    {
        float a, b;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("first");
        }
        else
        {
            if (b > a)
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("eqals");
            }
        }
    }
}