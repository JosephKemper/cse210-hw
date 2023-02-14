using System;

namespace Learning04
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public void GetHomeworkList (string name, string topic, string textbookSection, string problems)
        {
            _textbookSection = textbookSection;
            _problems = problems;
            Console.WriteLine ($"{GetName(name)} - {GetTopic(topic)}");
            Console.WriteLine ($"{_textbookSection} {_problems}");

        }

    }
}