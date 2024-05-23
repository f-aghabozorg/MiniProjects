using Ex_13_IOCTextCommon;
using Ex_13_IOCTextDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextBL
{
    public class ArticleBL : BaseBL<Article>, IArticleBL, ISearchable
    {
        public string GetSearchQuery(string[] searchWord)
        {
            string query = $"select {nameof(Article.Name)} as 'col1'" +
                           $", {nameof(Article.Summary)} as 'col2'" +
                           $", {nameof(Article.Creator)} as 'col3'" +
                           $", '{nameof(Article)}' as 'Entity'" +
                           $" from {nameof(Article)}"
                   , where = "";

            foreach (string word in searchWord)
            {
                if (string.IsNullOrEmpty(where))
                    where += " where ";
                where += $" {nameof(Article.Name)} like N'%'+@p1+'%'" +
                         $" or {nameof(Article.Summary)} like N'%'+@p2+'%'" +
                         $" or {nameof(Article.Creator)} like N'%'+@p3+'%'";
            }

            return query + where;

        }
    }
}