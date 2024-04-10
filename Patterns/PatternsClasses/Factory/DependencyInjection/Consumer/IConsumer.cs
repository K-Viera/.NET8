using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory.DependencyInjection
{
    public interface IConsumer
    {
        void Execute(string command);
    }
}
