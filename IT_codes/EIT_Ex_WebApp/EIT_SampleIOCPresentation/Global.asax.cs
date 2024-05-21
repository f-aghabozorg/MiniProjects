using Ex_13_IOCTextBL;
using Ex_13_IOCTextCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace EIT_SampleIOCPresentation
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            UnityManager unityManager2 = new UnityManager();
            unityManager2.Container.RegisterType<ISearchable, NewsBL>("NewsBL");
            unityManager2.Container.RegisterType<ISearchable, ArticleBL>("ArticleBL");
            unityManager2.Container.RegisterType<ISearchable, NewsBL>("NewsBL");
            unityManager2.Container.RegisterType<ISearchable, ForumBL>("ForumBL");

            unityManager2.Container.RegisterType<INewsBL, NewsBL>();
            unityManager2.Container.RegisterType<IBookBL, BookBL>();
            unityManager2.Container.RegisterType<IArticleBL, ArticleBL>();
            unityManager2.Container.RegisterType<IForumBL, ForumBL>();

            unityManager2.Container.RegisterType<ISearchBL, SearchBL>();

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