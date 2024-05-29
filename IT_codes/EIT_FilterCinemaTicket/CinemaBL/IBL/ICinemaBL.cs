﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDA.IRepository;
using CinemaDA.Entities;

namespace CinemaBL.IBL
{
    public interface ICinemaBL : IBaseBL<IBaseDA<Cinema>, Cinema>
    {
    }
}