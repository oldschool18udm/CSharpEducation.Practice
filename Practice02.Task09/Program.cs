namespace Practice02.Task09;

class Program
{
    public static int[] intArrya(int n)
    {
        int[] arrya = new int[n];
        return arrya;
    }

    public  static void PrintArray(int[] arrya)
    {
        string arryaStr = string.Join(" ", arrya);
        Console.WriteLine(arryaStr);
    }
    static void Main(string[] args)
    {
        int k = Convert.ToInt32(Console.ReadLine());
        int[] arrya = intArrya(k);
        PrintArray(arrya);
    }
}