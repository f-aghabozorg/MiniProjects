using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Ex_15_2_DtoUniversityCMN
{
    public static class UnityManager
    {
        private static IUnityContainer container;

        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                    container = new UnityContainer();

                return container;
            }
            set { container = value; }
        }
    }


}
