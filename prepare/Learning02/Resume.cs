using System;

public class Resume
{
    // Store person's name
    public string _name;

    // Store list of jobs
    public List<Job> _jobsList = new List<Job>();

    public void DisplayResume()
    {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("Jobs:");
    foreach (Job job in _jobsList)
    {
        job.DisplayJob();
    }
    }

}