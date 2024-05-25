using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AbstractFactory
{
    public class Rectangle : IRectangle, IShape
    {
        public void Draw() => Console.WriteLine("Basic rectangle");
    }
}
