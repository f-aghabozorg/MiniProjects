using CinemaBL.IRepository;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaBL.IBL;
using CinemaDA.Repository;


namespace CinemaDA.Repository
{
    public class UserDA: BaseDA<User>, IUserDA
    {
    }
}