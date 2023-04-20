using FigureLib.Figures;

namespace FigureLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void InputValidationTest()
        {
            //Side can't be less or equal zero
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Triangle>(1, 1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Triangle>(1, 0, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Triangle>(0, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Triangle>(1, 1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Triangle>(1, -1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Triangle>(-1, 1, 1));

            //Triangle object can't create when triangle can't exists with this sides.
            Assert.Throws<ArgumentException>(() => FigureHelper.CalcArea<Triangle>(3, 4, 8));
            Assert.Throws<ArgumentException>(() => FigureHelper.CalcArea<Triangle>(15, 6, 5));
        }

        [Fact]
        public void CalcAreaTest()
        {
            Assert.Equal(7.806, FigureHelper.CalcArea<Triangle>(4,4,5),3);
        }

        [Fact]
        public void TriangleValidTest()
        {
            Assert.True(FigureHelper.IsValidTriangle(1, 1, 1), "Must be true, it's valid triangle");

            Assert.False(FigureHelper.IsValidTriangle(3, 4, 8), "Must be false, isn't valid triangle");
        }

        [Fact]
        public void RightTriangleTest()
        {
            Assert.False(FigureHelper.IsRightTriangle(1, 1, 1), "Must be false, it's not right triangle");

            Assert.True(FigureHelper.IsRightTriangle(3, 4, 5), "Must be true, it's right triangle");
        }
    }
}