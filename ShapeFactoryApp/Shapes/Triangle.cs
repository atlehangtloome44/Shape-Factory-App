using ShapeFactoryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Shapes
{
    public class Triangle : Shape
    {
        public float BaseWidth { get; set; }
        public float PerpHeight { get; set; }

        public Triangle(float baseWidth, float perpHeight)
        {
            BaseWidth = baseWidth;
            PerpHeight = perpHeight;
        }

        public float CalculateArea() => 0.5f * BaseWidth * PerpHeight;

        public float CaluclatePerimiter()
        {
            float hypotenuse = (float)Math.Sqrt(BaseWidth * BaseWidth + PerpHeight * PerpHeight);
            return hypotenuse + BaseWidth + PerpHeight;
        }

        public void Draw() => Console.WriteLine("Draw Triangle Shape ...");
    }
}
