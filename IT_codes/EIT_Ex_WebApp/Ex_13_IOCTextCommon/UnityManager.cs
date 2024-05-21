using Unity;

namespace Ex_13_IOCTextBL
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