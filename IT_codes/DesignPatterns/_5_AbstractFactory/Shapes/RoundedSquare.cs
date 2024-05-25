using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AbstractFactory
{
    public class RoundedSquare : ISquare,IShape
    {
        public void Draw() => Console.WriteLine("Rounded square");
    }
}
