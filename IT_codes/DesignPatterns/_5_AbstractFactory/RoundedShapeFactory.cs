using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AbstractFactory
{
    public class RoundedShapeFactory : ShapeFactory     
    {
        public override IShape Create(Shape shape)
        {
            switch (shape)
            {
                case Shape.Square:
                    return new RoundedSquare();    
                case Shape.Rectangle:
                    return new RoundedRectangle(); 
                default:
                    throw new ArgumentOutOfRangeException(
                    nameof(shape), shape, null);
            }
        }
    }
}
