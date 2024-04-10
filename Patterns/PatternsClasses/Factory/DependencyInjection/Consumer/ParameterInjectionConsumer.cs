using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory.DependencyInjection.Consumer
{
    //Also called method injection
    public class ParameterInjectionConsumer : IConsumer
    {
        //Code Smell
        public void Execute(string command)
        {
            throw new NotImplementedException();
        }

        public void Execute(string command,ILogger logger) {
            logger.Log(command);
        }
    }
}
