namespace Practice02.Task11;

public struct ArrayGenPrint
{
    public static int[] intArrya(int n, int k)
    {
        int[] arrya = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrya[i] = k;
        }

        return arrya;
    }

    public static void PrintArray(int[] arrya)
    {
        string arryaStr = string.Join(" ", arrya);
        Console.WriteLine(arryaStr);
    }
}