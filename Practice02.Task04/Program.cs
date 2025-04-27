namespace Practice02.Task04;

class Program
{
    static void Main(string[] args)
    {
        int h;
        Console.WriteLine("Enter the H");
        h = int.Parse(Console.ReadLine());
        string symbol;
        Console.WriteLine("Enter the Symbol");
        symbol = Console.ReadLine();
        string star=symbol, space= new string(' ',h);
        for (int i = 1; i <= h; i++)
        {
            Console.WriteLine(star);
            star += symbol;
        }

        star = symbol;
        for (int i = 0; i < h; i++)
        {
            Console.WriteLine(space+star);
            star += symbol;
            space= new string(' ',h-1-i);
        }
    }
}