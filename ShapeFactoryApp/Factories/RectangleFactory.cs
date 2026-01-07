using ShapeFactoryApp.Interfaces;
using ShapeFactoryApp.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Factories
{
    public class RectangleFactory : ShapeFactory
    {
        public Shape Create()
        {
            Console.Write("Enter width: ");
            float w = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            float h = float.Parse(Console.ReadLine());
            return new Rectangle(w, h);
        }

        public string GetShapeName() => "Rectangle";
    }
}
