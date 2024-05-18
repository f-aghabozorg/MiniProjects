using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Command
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
