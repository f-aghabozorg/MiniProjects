using Ex_15_UniversityBL;
using Ex_15_UniversityCMN;
using Ex_15_UniversityDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace EIT_University
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            UnityManager.Container.RegisterType<IUserDA, UserDA>();
            UnityManager.Container.RegisterType<ITeacherDA, TeacherDA>();
            UnityManager.Container.RegisterType<IStudentDA, StudentDA>();
            UnityManager.Container.RegisterType<IBaseDA, BaseDA>();

        }
    }
}