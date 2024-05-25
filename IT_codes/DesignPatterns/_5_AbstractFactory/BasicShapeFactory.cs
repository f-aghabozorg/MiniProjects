using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AbstractFactory
{
    public class BasicShapeFactory : ShapeFactory
    {
        public override IShape Create(Shape shape)
        {
            switch (shape)
            {
                case Shape.Square:
                    return (new Square() as IShape);
                case Shape.Rectangle:
                    return (new Rectangle() as IShape);
                default:
                    throw new ArgumentOutOfRangeException(
                    nameof(shape), shape, null);
            }
        }
    }
}
