using FigureAreaCalculator.Models;

namespace FigureAreaCalculator.Services
{
    class FigureFactory
    {
        public static IFigure CreateShape(int figureType, params double[] parameters)
        {
            switch (figureType)
            {
                case 1:
                    if (parameters.Length == 1)
                    {
                        double radius = parameters[0];
                        return new Circle(radius);
                    }
                    break;
                case 2:
                    if (parameters.Length == 3)
                    {
                        double sideA = parameters[0];
                        double sideB = parameters[1];
                        double sideC = parameters[2];
                        Triangle triangle = new Triangle(sideA, sideB, sideC);

                        bool isRectangular = triangle.IsRectangular();
                        if (!isRectangular)
                        {
                            Console.WriteLine("Triangle is not rectangular!");
                        }

                        return new Triangle(sideA, sideB, sideC);
                    }
                    break;
            }

            throw new ArgumentException("Invalid figure type or parameters");
        }
    }
}
