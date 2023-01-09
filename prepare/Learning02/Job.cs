public class Job
{
    // store _company as string
    public string _company;
    //  store _jobTitle as string
    public string _jobTitle;
    // store _startYear as int
    public int _startYear;
    // store _endYear as int
    public int _endYear;

    public void DisplayJob()
    {
    // Display info for user in this pattern 
    // "Job Title (Company) StartYear-EndYear"
    Console.WriteLine ($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}