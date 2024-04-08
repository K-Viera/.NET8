using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<Toppings> Toppings = new List<Toppings>();
        public double Price { get; set; }
        public Pizza(string dough, string sauce) {
            this.Dough = dough;
            this.Sauce = sauce;
        }
        public void Print() {
            Console.WriteLine($"Pizza Dought:{Dough}, Sauce:{Sauce}");
        }
    }

    public enum Toppings
    {
        Pepperoni,
        Sausage,
        Mushrooms,
        Pineapple,
        Bacon
    }
}
