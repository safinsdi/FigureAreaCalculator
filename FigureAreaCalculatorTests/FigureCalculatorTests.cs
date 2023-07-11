using FigureAreaCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FigureAreaCalculatorTests
{
    public class FigureCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            //arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            //act
            double area = Math.Round(circle.CalculateArea(), 5);

            //assert
            Assert.AreEqual(area, 78.53982);
        }

        [Test]
        public void GetTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            double area = triangle.CalculateArea();

            //assert
            Assert.AreEqual(area, 6);
        }

        [Test]
        public void CheckIsTriangleRectangular_CorrectRatioOfSides_ReturnsTrue()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            bool isRectangular = triangle.IsRectangular();

            //assert
            Assert.AreEqual(isRectangular, true);
        }

        [Test]
        public void CheckIsTriangleRectangular_IncorrectRatioOfSides_ReturnsTrue()
        {
            //arrange
            Triangle triangle = new Triangle(3, 3, 5);

            //act
            bool isRectangular = triangle.IsRectangular();

            //assert
            Assert.AreEqual(isRectangular, false);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangleObject_InvalidSide_ThrowsArgumentException()
        {
            // arrange
            double side1 = -1;
            double side2 = 2;
            double side3 = 10;

            // assert
            Assert.ThrowsException<ArgumentException>(() => {
                Triangle triangle = new Triangle(side1, side2, side3);
            }, "Triangle sides must be greater than 0");
        }

    }
}