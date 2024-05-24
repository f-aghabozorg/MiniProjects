using Ex_15_BL = Ex_15_UniversityBL;
using Ex_15_CMN = Ex_15_UniversityCMN;
using Ex_15_DA = Ex_15_UniversityDA;

using Ex_15_2_BL = Ex_15_2_DtoUniversityBL;
using Ex_15_2_CMN = Ex_15_2_DtoUniversityCMN;
using Ex_15_2_DA = Ex_15_2_DtoUniversityDA;
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


            //Exercise 15-16-2
            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.IUserDA, Ex_15_2_DA.UserDA>();
            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.ITeacherDA, Ex_15_2_DA.TeacherDA>();
            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.IStudentDA, Ex_15_2_DA.StudentDA>();
            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.IBaseDA, Ex_15_2_DA.BaseDA>();

            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.IUserBL, Ex_15_2_BL.UserBL>();
            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.ITeacherBL, Ex_15_2_BL.TeacherBL>();
            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.IStudentBL, Ex_15_2_BL.StudentBL>();
            Ex_15_2_CMN.UnityManager.Container.RegisterType<Ex_15_2_BL.IBaseBL, Ex_15_2_BL.BaseBL>();

            //Exercise 15-16
            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.IUserDA, Ex_15_DA.UserDA>();
            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.ITeacherDA, Ex_15_DA.TeacherDA>();
            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.IStudentDA, Ex_15_DA.StudentDA>();
            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.IBaseDA, Ex_15_DA.BaseDA>();

            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.IUserBL, Ex_15_BL.UserBL>();
            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.ITeacherBL, Ex_15_BL.TeacherBL>();
            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.IStudentBL, Ex_15_BL.StudentBL>();
            Ex_15_CMN.UnityManager.Container.RegisterType<Ex_15_BL.IBaseBL, Ex_15_BL.BaseBL>();

        }
    }
}