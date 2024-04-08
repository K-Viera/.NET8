using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory
{
    public class BoatCreator : DelivererCreator
    {
        public override IDeliverer DelivererFactory()
        {
            return new BoatDeliverer();
        }

        public override string Load(IDeliverer deliverer)
        {
            deliverer.LoadMethod = "Containerized cargo";
            return deliverer.LoadMethod;
        }
    }
}
