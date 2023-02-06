using System;
using System.Collections.Generic;
using System.Linq;

namespace split_string_to_list
{
    class Program
    {
        static void Main(string[] args)
        {
            string split = "this, needs, to, split";
            List<string> list = new List<string>();
            list = split.Split(',').ToList();
            Console.WriteLine(list);
        }
    }
}