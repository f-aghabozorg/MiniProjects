using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EIT_SampleIOC
{
    public class DTO
    {
        public class NewsDTO
        {
            public int Id { get; set; }
            public string HeadLine { get; set; }
            public string Reporter { get; set; }
            public string Summary { get; set; }
            public string Text { get; set; }
            public string Title { get; set; }

        }
        public class BookDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Summary { get; set; }
            public string Creator { get; set; }
        }
        public class ArticleDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Summary { get; set; }
            public string Creator { get; set; }
        }
        public class ForumDTO
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Topic { get; set; }
            public string Text { get; set; }
        }

    }
}