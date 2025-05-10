namespace Practice03.Task02;

public class Student
{
    public  string name;
    public   int age;
    private float mean;

    public float Mean
    {
        set
        {if (0<=value && value<=5)
            mean=value;
        }
        get{return mean;}
    }

    public  void PrintStudent()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Mean: {Mean}");
    }
}