using Ex_13_IOCTextBL;
using Ex_13_IOCTextCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace EIT_SampleIOC
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            UnityManager unityManager = new UnityManager();
            unityManager.Container.RegisterType<ISearchable, NewsBL>("SearchNewsBL");
            unityManager.Container.RegisterType<ISearchable, ArticleBL>("SearchArticleBL");
            unityManager.Container.RegisterType<ISearchable, BookBL>("SearchBookBL");
            unityManager.Container.RegisterType<ISearchable, ForumBL>("SearchForumBL");

            unityManager.Container.RegisterType<INewsBL, NewsBL>("NewsBL");
            unityManager.Container.RegisterType<IBookBL, BookBL>("BookBL");
            unityManager.Container.RegisterType<IArticleBL, ArticleBL>("ArticleBL");
            unityManager.Container.RegisterType<IForumBL, ForumBL>("ForumBL");

            unityManager.Container.RegisterType<ISearchBL, SearchBL>("SearchBL");

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