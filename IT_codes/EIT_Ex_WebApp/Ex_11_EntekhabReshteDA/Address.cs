﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EntekhabReshteDA
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string FullAddress { get; set; }
        public User User { get; set; }

    }
}