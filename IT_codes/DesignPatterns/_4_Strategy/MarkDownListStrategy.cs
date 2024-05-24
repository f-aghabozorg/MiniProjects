using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Strategy
{
    public class MarkdownListStrategy : IListStrategy
    {
        // markdown doesn't require list start/end tags
        public void Start(StringBuilder sb) { }
        public void End(StringBuilder sb) { }
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }
    }
}
