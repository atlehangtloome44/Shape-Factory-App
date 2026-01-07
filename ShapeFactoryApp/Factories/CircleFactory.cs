using ShapeFactoryApp.Interfaces;
using ShapeFactoryApp.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Factories
{
    public class CircleFactory : ShapeFactory
    {
        public Shape Create()
        {
            Console.Write("Enter radius: ");
            float r = float.Parse(Console.ReadLine());
            return new Circle(r);
        }

        public string GetShapeName() => "Circle";
    }
}
