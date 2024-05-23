using Ex_13_IOCTextBL;
using Ex_13_IOCTextCommon;
using Ex_13_IOCTextDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

namespace EIT_SampleIOC
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //exercise 13 - 14
            UnityManager unityManager = new UnityManager();
            INewsBL News = unityManager.Container.IsRegistered<INewsBL>("NewsBL") ? unityManager.Container.Resolve<INewsBL>("NewsBL") : null;
            IBookBL Books = unityManager.Container.Resolve<IBookBL>("BookBL");
            IArticleBL Articles = unityManager.Container.Resolve<IArticleBL>("ArticleBL");
            IForumBL Forums = unityManager.Container.Resolve<IForumBL>("ForumBL");

            News.Insert(new News()
            {
                Id = 1
                ,
                HeadLine = "Ex_13_defualt_HeadLine: BitCoin"
                ,
                Reporter = "Ex_13_defualt_Reporter: Bob Roberts"
                ,
                Summary = "Ex_13_defualt_Summary: Bitcoin Value"
                ,
                Text = "Ex_13_defualt_Text: The live Bitcoin price today is $69970.52 USD "
                      + "with a 24-hour trading volume of $38733760125.65 USD."
                      + " We update our BTC to USD price in real-time."
                ,
                Title = "Ex_13_defualt_Title: Market Summary > Bitcoin"
            });


            Books.Insert(new Book()                         //ask how implement both dto - baseBL
            {
                Id = 1
                          ,
                Name = "Ex_13_defualt_Name"
                          ,
                Summary = "Ex_13_defualt_Summary"
                          ,
                Creator = "Ex_13_defualt_Creator"
            });

            Articles.Insert(new Article()
            {
                Id = 1
                         ,
                Name = "Ex_13_defualt_Name"
                         ,
                Summary = "Ex_13_defualt_Summary"
                         ,
                Creator = "Ex_13_defualt_Creator"
            });

            Forums.Insert(new Forum()
            {
                Id = 1
             ,
                Title = "Ex_13_defualt_Title"
             ,
                Topic = "Ex_13_defualt_Topic"
             ,
                Text = "Ex_13_defualt_Text"
            });

            ISearchable searchable_News = unityManager.Container.Resolve<ISearchable>("SearchNewsBL");
            ISearchable searchable_Books = unityManager.Container.Resolve<ISearchable>("SearchBookBL");
            ISearchable searchable_Articles = unityManager.Container.Resolve<ISearchable>("SearchArticleBL");
            ISearchable searchable_Forums = unityManager.Container.Resolve<ISearchable>("SearchForumBL");

            ISearchBL searchAll = unityManager.Container.Resolve<ISearchBL>("SearchBL");

            List<SearchAutoCompleteObject> Search_result = searchAll.GetSearchResult("defualt");


            Console.WriteLine(".");
        }


    }

}