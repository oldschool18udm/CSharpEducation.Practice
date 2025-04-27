namespace Practice02.Task12;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] arrya = StringArray.strArrya(n);
        StringArray.PrintArray(arrya);
    }
}