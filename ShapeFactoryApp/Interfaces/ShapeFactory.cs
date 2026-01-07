using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp.Interfaces
{
    public interface ShapeFactory
    {
        Shape Create();
        string GetShapeName();
    }
}

