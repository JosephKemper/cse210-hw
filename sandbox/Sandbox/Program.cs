using System;
using System.Collections.Generic;
using System.Linq;

namespace split_string_to_list
{
    class Program
    {
        static void Main(string[] args)
        {
        string _verseText = "Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail. Behold, I do not condemn you; go your ways and sin no more; perform with soberness the work which I have commanded you. Look unto me in every thought; doubt not, fear not.";
        string [] testString = _verseText.Split(" ");
        foreach (var word in testString)
        {
        Console.WriteLine(word);
        }

        Console.WriteLine();
        Console.WriteLine(testString [1]);

        }
    }
}
 