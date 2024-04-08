using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory
{
    internal class BoatDeliverer : IDeliverer
    {
        public string LoadMethod { get; set; }

        public string Deliver()
        {
            if (LoadMethod is null)
                throw new ArgumentNullException();
            return "Deliver by boat";
        }
    }
}
