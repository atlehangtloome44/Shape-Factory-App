using ShapeFactoryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Shapes
{
    public class Square : Shape
    {
        public float Width { get; set; }

        public Square(float width) => Width = width;

        public float CalculateArea() => Width * Width;

        public float CaluclatePerimiter() => 4 * Width;

        public void Draw() => Console.WriteLine("Draw Square Shape ...");
    }
}
