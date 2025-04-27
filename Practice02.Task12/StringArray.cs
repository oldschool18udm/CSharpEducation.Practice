namespace Practice02.Task12;

public struct StringArray
{
    public static string[] strArrya(int n)
    {
        string[] arrya = new String[n];
        for (int i = 0; i < n; i++)
        {
            arrya[i] = Console.ReadLine();
        }
        return arrya;
    }

    public static void PrintArray(string[] arrya)
    {
        string arryaStr = string.Join(" ", arrya);
        Console.WriteLine(arryaStr);
    }
}