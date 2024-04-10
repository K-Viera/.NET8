using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory.DependencyInjection
{
    public class ConcreteLogger : ILogger
    {
        public void Log(string message)
        {
           Console.WriteLine(message);
        }
    }
}
