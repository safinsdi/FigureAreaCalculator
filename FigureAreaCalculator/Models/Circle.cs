using System;


namespace FigureAreaCalculator.Models
{
    public class Circle : IFigure
    {
        private double Radius { init; get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0", nameof(radius));
            }

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }


}
