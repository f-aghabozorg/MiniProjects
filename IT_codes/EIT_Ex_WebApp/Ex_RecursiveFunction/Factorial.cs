using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_RecursiveFunction
{
    public class Factorial
    {
        public static int Factorial_Recursion(int number)
            => (number == 1) ? 1 : number * Factorial_Recursion(number - 1);
    }
}
