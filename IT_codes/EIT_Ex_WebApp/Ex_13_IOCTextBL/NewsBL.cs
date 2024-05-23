using Ex_13_IOCTextCommon;
using Ex_13_IOCTextDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextBL
{
    public class NewsBL : BaseBL<News>, INewsBL, ISearchable, IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public string GetSearchQuery(string[] searchWord)
        {
            string query = $"select {nameof(News.Title)} as 'col1'" +
                           $", {nameof(News.HeadLine)} as 'col2'" +
                           $", {nameof(News.Reporter)} as 'col3'" +
                           $", '{nameof(News)}' as 'Entity'" +
                           $" from {nameof(News)}"
                   , where = "";

            foreach (string word in searchWord)
            {
                if (string.IsNullOrEmpty(where))
                    where += " where ";
                where += $"{nameof(News.Title)} like N'%'+@p1+'%'" +
                         $" or {nameof(News.HeadLine)} like N'%'+@p2+'%'" +
                         $" or {nameof(News.Reporter)} like N'%'+@p3+'%'";
            }

            return query + where;

        }
    }
}