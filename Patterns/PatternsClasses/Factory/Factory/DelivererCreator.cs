using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory
{
    public abstract class DelivererCreator
    {
        public abstract IDeliverer DelivererFactory();
        public abstract string Load(IDeliverer deliverer);
        public string Deliver()
        {
            var deliverer = DelivererFactory();
            Load(deliverer);
            return $"Deliverer loaded by {deliverer.LoadMethod} and delivered by {deliverer.Deliver()}";
        }
    }
}
