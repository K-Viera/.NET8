using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory
{
    public class TruckCreator : DelivererCreator
    {
        public override IDeliverer DelivererFactory()
        {
            return new TruckDeliverer();
        }

        public override string Load(IDeliverer deliverer)
        {
            deliverer.LoadMethod = "Palletized load";
            return deliverer.LoadMethod;
        }
    }
}
