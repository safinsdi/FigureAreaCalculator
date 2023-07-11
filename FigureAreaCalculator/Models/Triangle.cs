using System;

namespace FigureAreaCalculator.Models
{
    public class Triangle : IFigure
    {
        private double _a {  get; init; }
        private double _b { get; init; }
        private double _c { get; init; }
        public Triangle(double a, double b, double c)
        {
            if (isValidTriangle(a, b, c))
            {
                _a = a;
                _b = b;
                _c = c;
            }
            else
            {
                throw new ArgumentException("Triangle sides must be greater than 0");
            }
        }
        public double CalculateArea()
        {
            double halfP = (_a + _b + _c) / 2;

            return Math.Sqrt(halfP * (halfP - _a) * (halfP - _b) * (halfP - _c));
        }

        public bool IsRectangular()
        {
            bool isRectangular = _a * _a + _b * _b == _c * _c
                || _a * _a + _c * _c == _b * _b
                || _b * _b + _c * _c == _a * _a;

            return isRectangular;
        }

        private bool isValidTriangle(double a, double b, double c)
        {

            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            return true;

        }
    }


}
