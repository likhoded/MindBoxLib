using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib.Shapes.CalculateShapes
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius > 0)
                Radius = radius;
        }
        protected sealed override double CalculateShapes()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
