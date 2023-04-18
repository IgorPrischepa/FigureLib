using FigureLib.Contracts;
using FigureLib.Figures;


namespace FigureLib
{
    public static class FigureHelper
    {
        public static double CalcArea(Figure figure)
        {
            return figure.CalcArea();
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            return Triangle.IsRightTriangle(a, b, c);
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            return (Triangle.IsValidTriangle(a, b, c));
        }
    }
}