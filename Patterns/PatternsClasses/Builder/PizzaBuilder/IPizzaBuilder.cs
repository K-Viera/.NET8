using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Builder
{
    public interface IPizzaBuilder
    {
        public IPizzaBuilder AddSauce();
        public IPizzaBuilder AddDough();
        public Pizza CreatePizzaBase();
    }
}
