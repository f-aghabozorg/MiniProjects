using Ex_13_IOCTextCommon;
using Ex_13_IOCTextDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextBL
{
    public class ForumBL : BaseBL<Forum>, IForumBL, ISearchable
    {

        public string GetSearchQuery(string[] searchWord)
        {
            string query = $"select {nameof(Forum.Title)} as 'col1'" +
                           $", {nameof(Forum.Topic)} as 'col2'" +
                           $", {nameof(Forum.Text)} as 'col3'" +
                           $", '{nameof(Forum)}' as 'Entity'" +
                           $" from {nameof(Forum)}"
                   , where = "";

            foreach (string word in searchWord)
            {
                if (string.IsNullOrEmpty(where))
                    where += " where ";
                where += $"{nameof(Forum.Title)} like N'%'+@p1+'%'" +
                         $" or {nameof(Forum.Topic)} like N'%'+@p2+'%'" +
                         $" or {nameof(Forum.Text)} like N'%'+@p3+'%'";
            }

            return query + where;
        }
    }
}
