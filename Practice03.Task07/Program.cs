namespace Practice03.Task07;

class Program
{
    enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    static int CurMonth(Month month)
    {
        switch (month)
        {
            case Month.January:
            case Month.March:
            case Month.May:
            case Month.July:
            case Month.August:
            case Month.October:
            case Month.December: return 31;
            case Month.February: return 28;
            default: return 30;
        }
    }

    static void Main(string[] args)
    {
        Month month = Month.April;
        int days =CurMonth(month);
        Console.WriteLine(month);
        Console.WriteLine(days);
    }
}