using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib.Shapes
{
    public abstract class Shape
    {
        private readonly Lazy<double> _square;
        public double Square => _square.Value;

        protected Shape()
        {
            _square = new Lazy<double>(CalculateShapes);
        }

        protected abstract double CalculateShapes();
    }
}
