using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    public class Fibbonachi
    {
        public static int Fibbonachi_Recursion(int number)
             => (number <= 2) ? 1 : Fibbonachi_Recursion(number - 1) + Fibbonachi_Recursion(number - 2);
    }
}
