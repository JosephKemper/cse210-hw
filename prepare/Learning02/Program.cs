using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Technical Support Project Supervisor";
        job1._company = "NorthStar Home Security";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job ();
        job2._jobTitle = "Virtual Support Specialist";
        job2._company = "ADT";
        job2._startYear = 2022;
        job2._endYear = 2022;

        job1.DisplayJob();
        job2.DisplayJob();

    }
}