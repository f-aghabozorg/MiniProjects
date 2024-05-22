﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renderers
{
    public interface IRenderer
    {
        void RenderCircle(float radius);
        void RenderTriangle(float radius);

        // RenderSquare, RenderTriangle, etc.
    }
}