using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Factory
{
    public interface IDeliverer
    {
        public string LoadMethod { get; set; }
        public string Deliver();
    }
}
