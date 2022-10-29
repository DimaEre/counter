using System;
using System.Collections.Specialized;
class лічильник
{
    public int item;
    public лічильник()
    {
       item = 58;    
    }
    public int increase()
    {
        if (item < 59) item++;
        else item = 0;
        return item;
    }
}
class Program
{
    
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        лічильник A = new лічильник();
        while (true)
        {
            Console.WriteLine("Введіть + для збільшення ліччильника на 1:   ");
            if (Console.ReadLine() == "+") Console.WriteLine(A.increase());
        }
    }
}
