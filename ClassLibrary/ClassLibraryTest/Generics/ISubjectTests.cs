using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest.Generics
{
    public interface ISubjectTests
    {
        public string Subject { get; set; }
        public List<Test> Tests { get; set; }
    }
}
