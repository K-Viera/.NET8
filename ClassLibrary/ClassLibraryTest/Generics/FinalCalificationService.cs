using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTest.Generics
{
    public class FinalCalificationService<T> where T : ISubjectTests
    {
        public static float GetFinal(T obj)
        {
            var test = obj.Tests.Select(x=>x.CalculateFinalGrade()).ToList();
            return test.Sum();
        }
    }
}
