using Ex_13_IOCTextBL;
using Ex_13_IOCTextCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

namespace EIT_SampleIOCPresentation
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnityManager unityManager = new UnityManager();
            unityManager.Container.RegisterType<ISearchable, NewsBL>("NewsBL");
            unityManager.Container.RegisterType<ISearchable, ArticleBL>("ArticleBL");
            unityManager.Container.RegisterType<ISearchable, NewsBL>("NewsBL");
            unityManager.Container.RegisterType<ISearchable, ForumBL>("ForumBL");

            unityManager.Container.RegisterType<INewsBL, NewsBL>();
            unityManager.Container.RegisterType<IBookBL, BookBL>();
            unityManager.Container.RegisterType<IArticleBL, ArticleBL>();
            unityManager.Container.RegisterType<IForumBL, ForumBL>();

            unityManager.Container.RegisterType<ISearchBL, SearchBL>();

            //exercise 13 - 14
            //UnityManager unityManager = new UnityManager();
            Console.WriteLine();
            INewsBL News = unityManager.Container.IsRegistered<INewsBL>("NewsBL") ? unityManager.Container.Resolve<INewsBL>("NewsBL") : null;
            //IBookBL Book = unityManager.Container.Resolve<IBookBL>("BookBL");
            //IArticleBL Article = unityManager.Container.Resolve<IArticleBL>("ArticleBL");
            //IForumBL Forum = unityManager.Container.Resolve<IForumBL>("ForumBL");
            Ex_13_IOCTextDA.News n = new Ex_13_IOCTextDA.News() { Id = 1, HeadLine = "defualt", Reporter = "defualt", Summary = "defualt", Text = "defualt", Title = "defualt" };
            News.Insert(new Ex_13_IOCTextDA.News() { Id = 1, HeadLine = "defualt", Reporter = "defualt", Summary = "defualt", Text = "defualt", Title = "defualt" });

            ISearchable searchable_News = unityManager.Container.Resolve<ISearchable>("NewsBL");
            ISearchable searchable_Books = unityManager.Container.Resolve<ISearchable>("NewsBL");
            ISearchable searchable_Articles = unityManager.Container.Resolve<ISearchable>("ArticleBL");
            ISearchable searchable_Forums = unityManager.Container.Resolve<ISearchable>("ForumBL");

            ISearchBL searchAll = unityManager.Container.Resolve<ISearchBL>();

            List<SearchAoutoCompleteObject> a = searchAll.GetSearchResult("defualt text");
            Console.WriteLine(".");
        }
    }
}