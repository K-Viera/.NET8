using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Builder
{
    public class SpicyPizzaBuilder : BasicPizzaBuilder, IPizzaBuilder
    {
        public IPizzaBuilder AddSauce()
        {
            // Logic for adding spicy marinara sauce
           base.ModifySauce("spicy marinara");
            return this;
        }

        public IPizzaBuilder AddDough()
        {
            // Logic for using whole wheat dough
            base.ModifyDough("whole wheat");
            return this;
        }
    }
}
