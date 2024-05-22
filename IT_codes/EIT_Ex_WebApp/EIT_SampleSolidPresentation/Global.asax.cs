using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Ex_12_2_SampleSolidBL;
using Ex_12_2_SampleSolidDA;
using Unity;

namespace EIT_SampleSolidPresentation
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            UnityManager unityManager = new UnityManager();
            unityManager.Container.RegisterType<IPackaging, Cartooni>("Cartooni"); //unityManager.Container.RegisterType<IPackaging, Cartooni>("Taghy");
            unityManager.Container.RegisterType<IPackaging, Biskooiti>("Biskooiti");
            unityManager.Container.RegisterType<IPackaging, Conservi>("Conservi");
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