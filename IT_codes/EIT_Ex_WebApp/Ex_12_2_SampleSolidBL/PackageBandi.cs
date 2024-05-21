using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_2_SampleSolidBL
{
    public class PackageBandi
    {
        public IPackaging type { get; set; }
        public PackageBandi(IPackaging type)
        {
            this.type = type;
           
        }
        public void Packaging() 
        {
            type.Packaging();
            type.PackageCost();
        }
    }
}
