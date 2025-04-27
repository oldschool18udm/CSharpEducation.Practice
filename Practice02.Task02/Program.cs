namespace Practice02.Task02;

class Program
{
    static void Main(string[] args)
    {
        //a
        float metr;
        Console.WriteLine("Enter the metr");
        metr = float.Parse(Console.ReadLine());
        Console.WriteLine(metr*0.001);
        //b
        float km;
        Console.WriteLine("Enter the km");
        km = float.Parse(Console.ReadLine());
        Console.WriteLine(km*100000);
        // c
        float ms;
        Console.WriteLine("Enter the m/s");
        ms = float.Parse(Console.ReadLine());
        Console.WriteLine(ms*1000.0f/3600);
        //d
        float c,f;
        Console.WriteLine("Enter the C");
        c = float.Parse(Console.ReadLine());
        f = 9.0f/5*c+32;
        Console.WriteLine(f);
    }
}