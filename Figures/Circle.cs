using FigureLib.Contracts;

namespace FigureLib.Figures
{
    public sealed class Circle : Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Create circle with scpecified radius
        /// </summary>
        /// <param name="radius">Positive number represents radius of circle</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw if number less or eqaual zero</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Circle radius must be a positive number");
            }

            _radius = radius;
        }


        internal override double CalcArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}