using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Strategy
{
    public interface IListStrategy
    {
        void Start(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
        void End(StringBuilder sb);
    }

}
