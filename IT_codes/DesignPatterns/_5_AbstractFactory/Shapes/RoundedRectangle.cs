using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AbstractFactory
{
    public class RoundedRectangle : IRectangle,IShape
    {
        public void Draw() => Console.WriteLine("Rounded rectangle");
    }
}
