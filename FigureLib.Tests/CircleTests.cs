using FigureLib.Figures;
using Xunit;

namespace FigureLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void InputValidationTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Fact]
        public void AreaCalcTest()
        {
            Circle circle = new(3);

            Assert.Equal(28.274, FigureHelper.CalcArea(circle), 3);
        }
    }
}