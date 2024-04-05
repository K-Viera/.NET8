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
            var totalPercentaje = obj.Tests.Select(x => x.Percentaje).Sum();
            if (totalPercentaje != 1) {
                throw new NotFullPercejateException("The sum of the percentajes must be 1");
            }
            var test = obj.Tests.Select(x=>x.CalculateFinalGrade()).ToList();
            return test.Sum();
        }
    }

    public class NotFullPercejateException : Exception
    {
        public NotFullPercejateException(string message) : base(message)
        {
        }
    }
}
