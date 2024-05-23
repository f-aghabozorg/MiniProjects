using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextBL
{
    public interface ISearchBL
    {
        List<SearchAutoCompleteObject> GetSearchResult(string text);
    }
}