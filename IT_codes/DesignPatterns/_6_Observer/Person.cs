﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Observer
{
    public class Person
    {
        public event EventHandler<FallsIllEventArgs>? FallsIll;
        public void CatchACold()
        {
            FallsIll?.Invoke(this, new FallsIllEventArgs { Address = "123 London Road" });
        }
    }
}
