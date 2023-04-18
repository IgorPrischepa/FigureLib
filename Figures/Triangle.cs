using FigureLib.Contracts;

namespace FigureLib.Figures
{
    public sealed class Triangle : Figure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        /// <summary>
        /// Create triangle with specified sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        ///    /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Side can't be less or equal zero");

            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Triangle with provided sides can't exist.");
            }

            _a = a;
            _b = b;
            _c = c;
        }


        internal override double CalcArea()
        {
            double semiPerimeter = (_a + _b + _c) / 2.0;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
        }

        /// <summary>
        /// Check if triangle can exist.
        /// </summary>
        /// <param name="a">Side "a"</param>
        /// <param name="b">Side "b"</param>
        /// <param name="c">Side "c"</param>
        /// <returns>True if can exist, otherwise false.</returns>
        internal static bool IsValidTriangle(double a, double b, double c)
        {
            if (a + b > c && b + c > a && c + a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if triangle is right
        /// </summary>
        /// <param name="a">Side "a"</param>
        /// <param name="b">Side "b"</param>
        /// <param name="c">Side "c"</param>
        /// <returns>True if triangle is right, otherwise false.</returns>
        internal static bool IsRightTriangle(double a, double b, double c)
        {
            if (IsValidTriangle(a, b, c))
            {
                double hypotenuseSquared = Math.Max(Math.Max(a, b), c);

                hypotenuseSquared *= hypotenuseSquared;

                double squaredA = a * a;
                double squaredB = b * b;
                double squaredC = c * c;

                if (hypotenuseSquared == squaredA + squaredB || hypotenuseSquared == squaredA + squaredC || hypotenuseSquared == squaredB + squaredC)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
