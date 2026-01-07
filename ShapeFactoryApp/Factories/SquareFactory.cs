using ShapeFactoryApp.Interfaces;
using ShapeFactoryApp.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Factories
{
    public class SquareFactory : ShapeFactory
    {
        public Shape Create()
        {
            Console.Write("Enter width: ");
            float w = float.Parse(Console.ReadLine());
            return new Square(w);
        }

        public string GetShapeName() => "Square";
    }
}
