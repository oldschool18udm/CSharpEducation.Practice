namespace Practice02.Task15;

class Program
{
    public static int[] intArrya(int n)
    {
        Random rnd = new Random();
        int[] arrya = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrya[i] = rnd.Next(100);
        }

        return arrya;
    }

    public static void PrintArray(int[] arrya)
    {
        string arryaStr = string.Join(" ", arrya);
        Console.WriteLine(arryaStr);
    }

    static void ReverseArray(int[] arrya)
    {
        for (int i = 0; i < arrya.Length / 2; i++)
        {
            int temp = arrya[i];
            arrya[i] = arrya[arrya.Length - 1 - i];
            arrya[arrya.Length - 1 - i] = temp;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] arrya = intArrya(10);
        PrintArray(arrya);
        ReverseArray(arrya);
        PrintArray(arrya);
    }
}