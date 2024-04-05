using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest.Polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape.Draw");
        }

        public virtual float CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        private int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Circle.Draw");
        }

        public override float CalculateArea()
        {
            return 3.14f * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        private int Width { get; set; }
        private int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle.Draw");
        }

        public override float CalculateArea()
        {
            return Width * Height;
        }
    }

}
