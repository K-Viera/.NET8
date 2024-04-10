using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory.DependencyInjection
{
    public class ConstructorInjectionConsumer : IConsumer
    {
        private ILogger Logger;
        public ConstructorInjectionConsumer(ILogger logger){
            Logger = logger;
        }
        public void Execute(string c)
        {
            Logger.Log(c);
        }
    }
}
