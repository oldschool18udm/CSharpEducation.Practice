namespace Practice02.Task25;

class Program
{
    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main(string[] args)
    {
        var weekLen = Enum.GetNames(typeof(Week)).ToList().Count;
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= weekLen)
            Console.WriteLine(Enum.GetNames(typeof(Week)).GetValue(n - 1));
        else
        {
            Console.WriteLine("Error");
        }
    }
}