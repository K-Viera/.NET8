using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest.Polymorphism
{
    public class PolymorphismLogic : ILogic
    {
        public string _name = "Polymorphism";
        public string Name { get { return _name; } }
        private static void AddShapes()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(10),
                new Rectangle(10, 20),
                new Circle(20),
                new Rectangle(20, 30),
                new Circle(30)
            };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine($"Area: {shape.CalculateArea()}");
            }
        }

        public void ExecuteLogic()
        {
            AddShapes();
        }
    }
}
