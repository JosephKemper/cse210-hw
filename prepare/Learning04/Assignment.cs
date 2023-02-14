using System;

namespace Learning04
{
    public class Assignment
    {
    private string _studentName;
    private string _topic;

    public string GetSummary ()
    {
        return $"{_studentName} - {_topic}";
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