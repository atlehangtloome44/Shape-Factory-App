using ShapeFactoryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Shapes
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public float CalculateArea() => Width * Height;

        public float CaluclatePerimiter() => 2 * Width + 2 * Height;

        public void Draw() => Console.WriteLine("Draw Rectangle Shape ...");
    }
}
