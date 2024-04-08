using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PatternsClasses.Builder
{
    public abstract class BasicPizzaBuilder
    {
        protected string? Sauce;
        protected string? Dough;
        protected void ModifySauce(string sauce) {
            Sauce = sauce;
        }
        protected void ModifyDough(string dought)
        {
            Dough = dought;
        }

        public Pizza CreatePizzaBase()
        {
            if (Sauce is null || Dough is null)
                throw new ArgumentNullException();
            var pizza = new Pizza(Dough, Sauce);
            this.Reset();
            return pizza;

        }
        protected BasicPizzaBuilder() {
            this.Reset();
        }
        protected void Reset()
        {
            Sauce = null;
            Dough = null;
        }
    }
}
