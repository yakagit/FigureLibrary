using FigureLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateArea_16and10and24_120returned()
        {
            // Arrange
            double sideA = 26d;
            double sideB = 10d;
            double sideC = 24d;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 120d;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void IsRightTriangle_26and10and24_TrueReturnet()
        {
            // Arrange
            double sideA = 26d;
            double sideB = 10d;
            double sideC = 24d;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool expectedArea = true;

            // Act
            bool actualArea = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
