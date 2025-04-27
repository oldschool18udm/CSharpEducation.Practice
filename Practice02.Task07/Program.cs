namespace Practice02.Task07;

class Program
{
    static void Main(string[] args)
    {
        string stroka = Console.ReadLine();
        Console.WriteLine(stroka.ToLower());
        Console.WriteLine(stroka.ToUpper());
        if (stroka.Length >= 1)
        {
            stroka = char.ToUpper(stroka[0])+stroka.Substring(1).ToLower();
        }
        Console.WriteLine(stroka);
    }
}