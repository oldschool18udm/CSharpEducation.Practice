namespace PersonPRG;
using PersonLibrary;
class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = Convert.ToInt32(Console.ReadLine());
        Person person = new Person();
        person.Name = name;
        person.Age = age;
        person.Info();
    }
}