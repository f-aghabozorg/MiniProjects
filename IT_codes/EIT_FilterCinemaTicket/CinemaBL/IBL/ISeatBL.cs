using CinemaDA.IRepository;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBL.IBL
{
    public interface ISeatBL : IBaseBL<IBaseDA<Seat>, Seat>
    {
    }
}
