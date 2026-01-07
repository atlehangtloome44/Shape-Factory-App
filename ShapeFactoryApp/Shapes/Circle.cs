using ShapeFactoryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Shapes
{
    public class Circle : Shape
    {
        static float PI = MathF.PI;
        public float Radius { get; set; }

        public Circle(float r) => Radius = r;

        public float CalculateArea() => PI * Radius * Radius;

        public float CaluclatePerimiter() => 2 * PI * Radius;

        public void Draw() => Console.WriteLine("Draw Circle Shape ...");
    }
}
