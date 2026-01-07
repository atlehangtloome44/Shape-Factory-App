using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Interfaces
{
    public interface Shape
    {
        float CalculateArea();
        float CaluclatePerimiter();
        void Draw();
    }
}
