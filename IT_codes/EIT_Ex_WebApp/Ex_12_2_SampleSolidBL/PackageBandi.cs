using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_2_SampleSolidBL
{
    public class PackageBandi
    {
        public void Packaging(IPackaging type)
        {
            type.Packaging();
            type.PackageCost();
        }
    }
}
