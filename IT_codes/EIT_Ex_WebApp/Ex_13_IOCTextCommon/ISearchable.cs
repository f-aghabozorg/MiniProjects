using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextCommon
{
    public interface ISearchable
    {
        string GetSearchQuery(string[] searchWord);
        
    }
}
