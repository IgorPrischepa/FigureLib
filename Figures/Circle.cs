using FigureLib.Contracts;

namespace FigureLib.Figures
{
    public sealed class Circle : Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Create circle with scpecified radius
        /// </summary>
        /// <param name="radius">Positive number represents radius of circle. Shuould be single number.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw if number less or eqaual zero</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throw if number less or eqaual zero</exception>
        internal Circle(params double[] radius)
        {
            if (radius.Length == 0 || radius.Length > 1)
                throw new ArgumentException("Invalid number of parameters");

            if (radius[0] <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Circle radius must be a positive number");

            _radius = radius[0];
        }

        internal override double CalcArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}