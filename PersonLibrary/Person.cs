namespace PersonLibrary;

public class Person
{
    private string name;
    private int age;
    public string Name
    {
        get { return name;} 
        set{ name=value;}
        
    }
    public int Age
    {
        get { return age;} set{age=value;} }

    public void Info()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}