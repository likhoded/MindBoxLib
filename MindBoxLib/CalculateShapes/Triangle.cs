using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib.Shapes.CalculateShapes
{
    public class Triangle : Shape
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        private readonly Lazy<bool> _isRectangular;
        public bool IsRectangular => _isRectangular.Value;

        public Triangle(double sideFirst, double sideSecond, double sideThird)
        {
            if (sideFirst < 0 || sideSecond < 0 || sideThird < 0)
                throw new ArgumentOutOfRangeException("Сторона должна быть положительной");

            FirstSide = sideFirst;
            SecondSide = sideSecond;
            ThirdSide = sideThird;

            _isRectangular = new Lazy<bool>(CheckIsRectangular);
        }

        private bool CheckIsRectangular()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        }

        protected sealed override double CalculateShapes()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            var firstSideCoefficient = semiPerimeter - FirstSide;
            var secondSideCoefficient = semiPerimeter - SecondSide;
            var thirdSideCoefficient = semiPerimeter - ThirdSide;

            return Math.Sqrt(semiPerimeter * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);
        }
    }
}
