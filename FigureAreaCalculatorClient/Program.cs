using FigureAreaCalculator.Models;
using FigureAreaCalculator.Services;
using System;

namespace FigureAreaCalculatorClient
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Select the shape type: (1 - Circle, 2 - Triangle)");

            int figureType = Convert.ToInt32(Console.ReadLine());

            IFigure figure;

            if (figureType == 1)
            {
                Console.Write("Enter radius of the circle:\n");
                double radius = Convert.ToDouble(Console.ReadLine());

                double[] factoryParameters = { radius };
                figure = FigureFactory.CreateShape(figureType, factoryParameters);

                double area = Math.Round(figure.CalculateArea(), 5);
                Console.WriteLine($"Calculated area of the circle is {area}");
            }
            else if (figureType == 2)
            {
                Console.Write("Enter sides of rectangle:\n");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());

                double[] factoryParameters = { a, b, c };
                figure = FigureFactory.CreateShape(figureType, factoryParameters);

                double area = Math.Round(figure.CalculateArea(), 5);
                Console.WriteLine($"Calculated area of the triangle is {area}");
            }
            else
            {
                throw new ArgumentException("Incorrect figure type");
            }

            Console.ReadKey();
        }
    }


}
