using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory
{
    public class TruckDeliverer : IDeliverer
    {
        public string LoadMethod { get; set; }

        public string Deliver()
        {
            if (LoadMethod is null)
                throw new Exception("Truck Not loaded");
            return "Delivered by truck";
        }
    }
}
