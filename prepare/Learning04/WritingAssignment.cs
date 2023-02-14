using System;

namespace Learning04
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        public void GetWritingInfo(string name,string topic, string title)
        {
            _title = title;
            GetSummary (name, topic);

            Console.WriteLine ($"{_title} by {GetName(name)}");
        }
    }
}