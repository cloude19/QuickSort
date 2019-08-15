using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    class Circle : Shapes
    {
        public int radius { get; set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int area()
        {
            return (int)Math.Round(2 * Math.PI * radius);
        }
    }
}
