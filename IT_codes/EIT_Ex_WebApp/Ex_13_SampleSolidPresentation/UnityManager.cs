using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Ex_13_SampleSolidPresentation
{
    public class UnityManager
    {
        private static IUnityContainer container;

        public IUnityContainer Container
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