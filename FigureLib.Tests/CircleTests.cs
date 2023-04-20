using FigureLib.Figures;

namespace FigureLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void InputValidationTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Circle>(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => FigureHelper.CalcArea<Circle>(0));
        }

        [Fact]
        public void AreaCalcTest()
        {
            Assert.Equal(28.274, FigureHelper.CalcArea<Circle>(3), 3);
        }
    }
}