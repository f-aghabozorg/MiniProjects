using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bridge
{
    public class Triangle : Shape
    {
        private float radius;
        public Triangle(IRenderer renderer, float radius) : base(renderer)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            renderer.RenderTriangle(radius);
        }
        public override void Resize(float factor)
        {
            radius *= factor;
        }

    }
}
