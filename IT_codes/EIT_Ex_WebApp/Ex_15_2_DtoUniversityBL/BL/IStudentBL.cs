using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15_2_DtoUniversityBL
{
    public interface IStudentBL :IBaseBL<IBaseDA<IStudent>, IStudent>
    {
    }
}
