using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest.Generics
{
    public class MathSubjectTests : ISubjectTests
    {
        public string _subject="Math";

        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = "Math";
            }
        }
        public List<Test> Tests { get; set; } = new List<Test>();
    }
}
