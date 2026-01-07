using ShapeFactoryApp.Interfaces;
using ShapeFactoryApp.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Factories
{
    public class TriangleFactory : ShapeFactory
    {
        public Shape Create()
        {
            Console.Write("Enter base width: ");
            float baseW = float.Parse(Console.ReadLine());
            Console.Write("Enter perpendicular height: ");
            float height = float.Parse(Console.ReadLine());
            return new Triangle(baseW, height);
        }

        public string GetShapeName() => "Triangle";
    }
}
