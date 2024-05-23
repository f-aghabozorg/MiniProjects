using Ex_13_IOCTextCommon;
using Ex_13_IOCTextDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextBL
{
    public class BookBL : BaseBL<Book>, IBookBL, ISearchable
    {
        public string GetSearchQuery(string[] searchWord)
        {
            string query = $"select {nameof(Book.Name)} as 'col1'" +
                           $", {nameof(Book.Summary)} as 'col2'" +
                           $", {nameof(Book.Creator)} as 'col3'" +
                           $", '{nameof(Book)}' as 'Entity'" +
                           $" from {nameof(Book)}"
                   , where = "";

            foreach (string word in searchWord)
            {
                if (string.IsNullOrEmpty(where))
                    where += " where ";
                where += $"{nameof(Book.Name)} like N'%'+@p1+'%'" +
                         $" or {nameof(Book.Summary)} like N'%'+@p2+'%'" +
                         $" or {nameof(Book.Creator)} like N'%'+@p3+'%'";
            }

            return query + where;

        }
    }
}