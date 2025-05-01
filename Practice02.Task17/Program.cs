namespace Practice02.Task17;

class Program
{
    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        
    }
    static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        swap(ref num1, ref num2);
        Console.WriteLine($"{num1}  {num2}");
    }
}