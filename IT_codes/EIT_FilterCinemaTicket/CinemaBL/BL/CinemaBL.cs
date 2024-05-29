using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaBL.IBL;
using CinemaDA.IRepository;
using CinemaDA.Entities;

namespace CinemaBL.BL
{
    public class CinemaBL : BaseBL<ICinemaDA, Cinema>, ICinemaBL
    {
    }
}
