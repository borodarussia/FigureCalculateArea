using Figure.Library.Models;
using Figure.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fiugre.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CheckRightangledTriangle()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 5.0);

            // Act
            var isRighangled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRighangled);
        }

        public void CheckNotRightangledeTriangle()
        {
            // Arrange
            var triangle = new Triangle(3.0, 3.0, 5.0);

            // Act
            var isRighangled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRighangled);
        }

        [Fact]
        public void CheckNegativeSide()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-1.0, 5.0, 3.0));
        }

        [Fact]
        public void CheckWrongSide()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(10.0, 1.0, 4.0));
        }

        [Fact]
        public void CheckCreateEqualSidedTriangle()
        {
            // Arrange
            IFigure triangle = default(IFigure);
            bool isCreated = true;

            try
            {
                triangle = new Triangle(1.0, 1.0, 1.0);

            }
            catch (ArgumentException ex) 
            {
                isCreated = false;
            }            

            // Act

            // Assert
            Assert.True(isCreated);
        }

        [Fact]
        public void CalculateSemiperimeter()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 5.0);

            // Act
            var semiperimeter = triangle.CalculateSemiperimeter();

            // Assert
            Assert.Equal(6.0, semiperimeter, 0.0001);
        }

        [Fact]
        public void CalculateTriangleSquare()
        {
            // Arrange
            var triangle = new Triangle(4.0, 6.0, 7.0);

            // Act
            var square = triangle.CalculateSquare();

            // Assert
            Assert.Equal(11.9765, square, 0.0001);
        }
    }
}
