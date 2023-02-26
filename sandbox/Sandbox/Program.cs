using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string filePath = "Reflecting Prompts.txt";
        List<string> lines = System.IO.File.ReadLines(filePath).ToList();
        // Display the list contents to the console
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}