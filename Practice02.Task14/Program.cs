namespace Practice02.Task14;

class Program
{
    static int[] intArrya(int n)
    {
        int[] arrya = new int[n];
        return arrya;
    }

    static void PrintArray(int[] arrya)
    {
        string arryaStr = string.Join(" ", arrya);
        Console.WriteLine(arryaStr);
    }
    static void Main(string[] args)
    {
        int k = Convert.ToInt32(Console.ReadLine());
        int[] arrya = intArrya(k);
        for (int i = 0; i < arrya.Length; i++)
        {
            arrya[i] = int.Parse(Console.ReadLine());
        }
        PrintArray(arrya);
    }
}