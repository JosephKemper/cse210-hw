using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        while (userInput != "quit"){
        Console.Clear();
        Console.WriteLine ("Doctrine and Covenants 6:34-36 Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail. Behold, I do not condemn you; go your ways and sin no more; perform with soberness the work which I have commanded you. Look unto me in every thought; doubt not, fear not.");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        userInput = Console.ReadLine ();
        }
    }
}