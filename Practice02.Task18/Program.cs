namespace Practice02.Task18;

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
            arrya[i] = rnd.Next(-100,100);
        }

        return arrya;
    }
    static int[] PositiveArray(int[] arrya, out int deleted)
    {
        deleted = 0;
        List<int> list = new List<int>();
        for (int i = 0; i < arrya.Length; i++)
        {
            if (arrya[i] < 0)
            {
                deleted++;
                
            }
            else
            {
                list.Add(arrya[i]);
            }
        }
        return list.ToArray();
    }
    static void Main(string[] args)
    {
        int[] arrya = intArrya(10);
        PrintArray(arrya);
        int k;
        int[] postivearr = PositiveArray(arrya, out k);
        PrintArray(postivearr);
        Console.WriteLine(k);
    }
}