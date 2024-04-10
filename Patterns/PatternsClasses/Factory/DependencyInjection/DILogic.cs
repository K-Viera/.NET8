using PatternsClasses.Factory.DependencyInjection.Consumer;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory.DependencyInjection
{
    public static class DILogic
    {
        private static IConsumer? Consumer { get; set; }
        public static void Execute() {
            var concreteLogger = new ConcreteLogger();

            //Constructor Injection
            Consumer = new ConstructorInjectionConsumer(concreteLogger);
            Consumer.Execute("Constructor Injection");

            //Parameter Injection
            var parameterConsumer = new ParameterInjectionConsumer();
            parameterConsumer.Execute("Parameter/Method Injection", concreteLogger);

        }
    }
}
