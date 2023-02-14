using System;

namespace Learning04
{
    public class Assignment
    {
    private string _studentName;
    private string _topic;

    public void GetSummary (string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;

        Console.WriteLine ($"{_studentName} - {_topic}");
    }

    public string GetName ()
    {
        return _studentName;
    }

    public string GetTopic ()
    {
        return _topic;
    }

    }
}