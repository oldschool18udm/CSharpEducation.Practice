namespace Practice03.Task03;

class Program
{
    static void Main(string[] args)
    {
        float a1=6;
        float a2=5;
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(a1, a2));
        Console.WriteLine(calc.Sub(a1, a2));
        Console.WriteLine(calc.Mult(a1, a2));
        Console.WriteLine(calc.Div(a1, a2));
    }
}