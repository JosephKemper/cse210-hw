using System;
namespace Learning04
{


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment newAssignment = new Assignment();

        newAssignment.GetSummary ("Samuel Bennett", "Multiplication");
        Console.WriteLine ();

        MathAssignment newMath = new MathAssignment();
        newMath.GetHomeworkList ("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");

        Console.WriteLine ();
    }
}
}