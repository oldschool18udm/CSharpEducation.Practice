using System.Diagnostics;

namespace Practice02.Task24;

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
        for (int i = 0; i < weekLen; i++)
            Console.WriteLine(Enum.GetNames(typeof(Week)).GetValue(i));
    }
}