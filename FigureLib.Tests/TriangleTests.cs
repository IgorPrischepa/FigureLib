using FigureLib.Figures;
using Xunit;

namespace FigureLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void InputValidationTest()
        {
            //Side can't be less or equal zero
            Assert.Throws<ArgumentOutOfRangeException>((() => new Triangle(1, 1, 0)));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>((() => new Triangle(1, 1, -1)));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 1));

            //Triangle object can't create when triangle can't exists with this sides.
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 8));
            Assert.Throws<ArgumentException>(() => new Triangle(15, 6, 5));
        }

        [Fact]
        public void CalcAreaTest()
        {
            Triangle triangle = new(3, 4, 4);

            Assert.Equal(5.562, triangle.CalcArea(), 3);
        }

        [Fact]
        public void TriangleValidTest()
        {
            Assert.True(Triangle.IsValidTriangle(1, 1, 1), "Must be true, it's valid triangle");

            Assert.False(Triangle.IsValidTriangle(3, 4, 8), "Must be false, isn't valid triangle");
        }

        [Fact]
        public void RightTriangleTest()
        {
            Assert.False(Triangle.IsRightTriangle(1, 1, 1), "Must be false, it's not right triangle");

            Assert.True(Triangle.IsRightTriangle(3, 4, 5), "Must be true, it's right triangle");
        }
    }
}