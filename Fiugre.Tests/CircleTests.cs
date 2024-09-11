using Figure.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fiugre.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CreateCircleWithNegativeRadius()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(-5.0, true));
        }

        [Fact]
        public void CreateCircleWithNegativeDiameter() 
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(-5.0, false));
        }

        [Fact]
        public void CreateCircleWithZeroRadius()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(0.0, true));
        }

        [Fact]
        public void CalculateSquareWithUsingRadius()
        {
            // Arrange
            var circle = new Circle(5.0, true);

            // Act
            var area = circle.CalculateSquare();

            // Assert
            Assert.Equal(78.5398, area, 0.0001);
        }

        [Fact]
        public void CalculateSquareWithUsingDiameter()
        {
            // Arrange
            var circle = new Circle(10.0, false);

            // Act
            var area = circle.CalculateSquare();

            // Assert
            Assert.Equal(78.5398, area, 0.0001);
        }

        [Fact]
        public void CalculateRadiusWithUsingDiameter()
        {
            // Arrange
            var circle = new Circle(10.0, false);

            // Act
            var radius = circle.Radius;

            // Assert
            Assert.Equal(5.0, radius, 0.0001);
        }

        [Fact]
        public void CalculateDiameterWithUsingRadius()
        {
            // Arrange
            var circle = new Circle(5.0, true);

            // Act
            var diameter = circle.Diameter;

            // Assert
            Assert.Equal(10.0, diameter, 0.0001);
        }
    }
}
