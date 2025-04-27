namespace Practice02.Task06;

class Program
{
    static void Main(string[] args)
    {
        //a
        string stroka0 = "qwerqwerqwe";
        char symbol0 = 'w';
        float k0 = stroka0.Count(c => c == symbol0);
        Console.WriteLine(k0 / stroka0.Length * 100);
        //b
        string stroka = Console.ReadLine();
        char symbol = Convert.ToChar(Console.ReadLine());
        float k = stroka.Count(c => c == symbol);
        Console.WriteLine(k / stroka.Length * 100);
        //c
        string stroka2 = args[0];
        char symbol2 = Convert.ToChar(args[1]);
        float k2 = stroka2.Count(c => c == symbol2);
        Console.WriteLine(k2 / stroka2.Length * 100);
    }
}