namespace Practice03.Task09b;

class Program
{  public static void Rename(Student s)
    {
        s.name = "Аноним";
    }
    static void Main(string[] args)
    {
        Student s = new Student();
        s.name = "Mark S";
        Console.WriteLine(s.name);
        Rename(s);
        Console.WriteLine(s.name);
    }
}