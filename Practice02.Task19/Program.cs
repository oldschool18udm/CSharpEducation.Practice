namespace Practice02.Task19;

class Program
{
    static void PrintArray(int[] arrya)
    {
        string arryaStr = string.Join(" ", arrya);
        Console.WriteLine(arryaStr);
    }
    static int[] intArrya(int n)
    {
        Random rnd = new Random();
        int[] arrya = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrya[i] = rnd.Next(1, 100);
        }

        return arrya;
    }
    static void Main(string[] args)
    {
        int[] arrya = intArrya(10);
        PrintArray(arrya);
        int maxel = arrya.Max();
        int minel = arrya.Min();
        Console.WriteLine(maxel-minel);
    }
}