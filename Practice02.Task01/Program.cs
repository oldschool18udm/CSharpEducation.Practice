namespace Practice02.Task01;

class Program
{
    static void Main(string[] args)
    {
        
        //a
        for (int i=0; i<10; i++){Console.Write(i+" ");}
        Console.WriteLine();
        //b
        int k = 0;
        while(k<10){Console.Write(k+" ");
            k++;
        }
        Console.WriteLine();
        //c
        k = 0;
        do
        {
            Console.Write(k + " ");
            k++;
        } while (k < 10);
        Console.WriteLine();
        //d
        string slova = "";
        for(int i=0; i<5; i++){slova +=Console.ReadLine()+" ";}
        Console.WriteLine(slova);
        //e  до ввода пустой строки
        slova = "";
        string e = Console.ReadLine();
        while (e != "")
        {
            slova += e + " ";
            e = Console.ReadLine();
        }
        Console.WriteLine(slova);
        
        // f до ввода пустой строки
        slova = "";
        e = Console.ReadLine();
        do
        {
            slova += e + " ";
            e = Console.ReadLine();
        } while (e != "");
        Console.WriteLine(slova);




    }
    
    
}