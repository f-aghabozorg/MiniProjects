using Ex_13_IOCTextBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EIT_SampleIOC.DTO;

namespace EIT_SampleIOC
{
    public class Insert
        //<Interface_Type, Object_Type, DTO_Type>
        //where Interface_Type : class
        //where Object_Type : class , new()
        //where DTO_Type : class
    {
        //public static void Insert()
        //{
        //    Object_Type t = new Object_Type();
            
        //    Interface_Type.Insert();

        //}
        public static void InsertNews(INewsBL News, NewsDTO newsDTO)
        {
           
            //News.Insert();
        }
        public static void InsertBook(IBookBL Books)
        {

        }
        public static void InsertArticle(IArticleBL Articles)
        {
            Articles.Insert(new Ex_13_IOCTextDA.Article()
            {
                Id = 1
                          ,
                Name = "Ex_13_defualt_Name"
                          ,
                Summary = "Ex_13_defualt_Summary"
                          ,
                Creator = "Ex_13_defualt_Creator"
            });
        }
        public static void InsertForum(IForumBL Forums)
        {
            Forums.Insert(new Ex_13_IOCTextDA.Forum()
            {
                Id = 1
              ,
                Title = "Ex_13_defualt_Title"
              ,
                Topic = "Ex_13_defualt_Topic"
              ,
                Text = "Ex_13_defualt_Text"
            });
        }

    }
}