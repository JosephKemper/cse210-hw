using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        List<object> mixedList = new List<object>();
        mixedList.Add(1);
        mixedList.Add("hello");
        
        foreach (object item in mixedList)
        {
            Console.WriteLine(item);
        }
    }
}