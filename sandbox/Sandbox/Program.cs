using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        var nums = new List<int> { 2, 1, 8, 0, 4, 3, 5, 7, 9 };

var enum1 = from num in nums
            orderby num
            select num;

foreach (var e in enum1)
{
    Console.Write($"{e} ");
}

Console.WriteLine();

var enum2 = from num in nums
            orderby num descending
            select num;

foreach (var e in enum2)
{
    Console.Write($"{e} ");
}

Console.WriteLine();
    }
}