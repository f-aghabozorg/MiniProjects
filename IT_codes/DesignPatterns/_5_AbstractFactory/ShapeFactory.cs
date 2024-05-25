using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AbstractFactory
{
    public abstract class ShapeFactory
    {
        public abstract IShape Create(Shape shape);
    }
}
