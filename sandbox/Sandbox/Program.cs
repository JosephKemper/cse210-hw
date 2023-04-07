using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var x = 0;
        while(x<=10)
        {
            x++;
            if(x == 2)continue;
            Console.WriteLine(x);
            if(x == 5) break;
            Console.WriteLine("End of loop body");
        }
        Console.WriteLine($"End of loop, X : {x}");
    }
}