using MathLibrary;
namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        
        Console.WriteLine( MathHelper.Add2(x,y));
        Console.WriteLine( MathHelper.Sub2(x,y));
        Console.WriteLine(MathHelper.Mul2(x,y));
        Console.WriteLine(MathHelper.Div2(x,y));
    }
}