﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renderers
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius}");
        }

        public void RenderTriangle(float radius)
        {
            Console.WriteLine($"Drawing a Triangle of radius {radius}");
        }
    }
}