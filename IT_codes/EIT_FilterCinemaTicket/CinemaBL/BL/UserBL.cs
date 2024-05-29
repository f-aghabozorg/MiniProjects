﻿using CinemaBL.IBL;
using CinemaDA.IRepository;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBL.BL
{
    public class UserBL: BaseBL<IUserDA, User>, IUserBL
    {
    }
}