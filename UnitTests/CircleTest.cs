using FigureLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea_14_615dot75returned()
        {
            // Arrange
            double radius = 14d;
            Circle circle = new Circle(radius);
            double expectedArea = 615.75;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
