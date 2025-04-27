namespace Practice02.Task23;

class Program
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine("Високосный");
        }
        else
        {
            Console.WriteLine("Невисокосный");
        }
    }
}