namespace Practice02.Task11;

class Program
{
    static void Main(string[] args)
    {
        int[] arrya = ArrayGenPrint.intArrya(Convert.ToInt32(Convert.ToInt32(args[0])), Convert.ToInt32(Convert.ToInt32(args[1])));
        ArrayGenPrint.PrintArray(arrya);
       
    }
}