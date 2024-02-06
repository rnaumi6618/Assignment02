using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Test
{
    public class RectangleTest
    {

        // Test method for SetLength
        [Test]
        [TestCase(100, 100)]
        [TestCase(-1, 1)]
        [TestCase(1100, 1100)]
        public void SetLength_DifferentValues_UpdatesAccordingly(int newLength, int expectedLength)
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act
            rectangle.SetLength(newLength);
            int actualLength = rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        // Test method for GetLength
        [Test]
        [TestCase(1, 1)]
        [TestCase(500, 500)]
        [TestCase(1000, 1000)]
        public void GetLength_AfterSettingLength_ReturnsExpectedValue(int setValue, int expectedValue)
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act
            rectangle.SetLength(setValue); 
            int actualLength = rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedValue, actualLength);
        }


        // Test method for SetWidth
        [Test]
        [TestCase(100, 100)]
        [TestCase(-1, 1)]
        [TestCase(1100, 1100)]
        public void SetWidth_DifferentValues_UpdatesAccordingly(int newWidth, int expectedWidth)
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act
            rectangle.SetWidth(newWidth);
            int actualWidth = rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        // Test method for GetWidth
        [Test]
        [TestCase(1, 1)]
        [TestCase(500, 500)]
        [TestCase(900, 900)]
        public void GetWidth_AfterSettingLength_ReturnsExpectedValue(int setValue, int expectedValue)
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act
            rectangle.SetWidth(setValue); 
            int actualWidth = rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedValue, actualWidth);
        }


        // Test method for GetPerimeter
        [Test]
        [TestCase(1, 1, 4)]
        [TestCase(10, 20, 60)]
        [TestCase(1100, 1100, 4400)]
        public void GetPerimeter_VariousDimensions_ReturnCorrectPerimeter(int length, int width, int expectedPerimeter)
        {
            //Arrange
            var rectangle = new Rectangle(length, width);

            //Act
            var actualPerimeter = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }


        // Test method for GetArea
        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(10, 20, 200)]
        [TestCase(100, 200, 20000)]
        public void GetArea_VariousDimensions_ReturnCorrectArea(int length, int width, int expectedArea)
        {
            //Arrange
            var rectangle = new Rectangle(length, width);

            //Act
            var actualArea = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
