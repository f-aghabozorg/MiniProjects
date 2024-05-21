using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Ex_12_2_SampleSolidBL;
using Ex_12_2_SampleSolidDA;
using Unity;

namespace Ex_13_SampleSolidPresentation
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Exercise 12
            Cartooni cartoony = new Cartooni();
            Conservi conservy = new Conservi();
            Biskooiti biskooity = new Biskooiti();

            PackageBandi packageBandi = new PackageBandi();
            packageBandi.Packaging(cartoony);

            packageBandi = new PackageBandi();
            packageBandi.Packaging(cartoony);

            packageBandi = new PackageBandi();
            packageBandi.Packaging(cartoony);

            //Exercise 13
            UnityManager unityManager = new UnityManager();
            IPackaging cartooni1 = unityManager.Container.Resolve<IPackaging>("Cartooni");
            IPackaging biskooity1 = unityManager.Container.Resolve<IPackaging>("Biskooiti");
            IPackaging conservy1 = unityManager.Container.Resolve<IPackaging>("Conservi");

            IPackaging cartoni = unityManager.Container.IsRegistered<IPackaging>("Cartooni")?
                unityManager.Container.Resolve<IPackaging>("Cartooni"): null;

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}