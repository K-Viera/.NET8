using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Builder
{
    public class ClassicPizzaBuilder : BasicPizzaBuilder, IPizzaBuilder
    {
        public IPizzaBuilder AddSauce()
        {
            //logic for classic tomato sauce
            base.ModifySauce("classic tomato");
            return this;
        }

        public IPizzaBuilder AddDough()
        {
            //logic for classic pizza dough
            base.ModifyDough("classic");
            return this;
        }
    }
}
