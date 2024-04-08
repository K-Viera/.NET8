using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory
{
    public static class LogicFactory
    {
        public static void Execute() {
            CreatorExecution(new TruckCreator());
            CreatorExecution(new BoatCreator());
        }
        public static void CreatorExecution(DelivererCreator delivererCreator)
        {
            Console.WriteLine("Executing..." + delivererCreator.Deliver());
        }
    }
}
