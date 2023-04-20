using FigureLib.Contracts;
using FigureLib.Figures;
using System.Reflection;


namespace FigureLib
{
    public static class FigureHelper
    {
        public static bool IsRightTriangle(double a, double b, double c)
        {
            return Triangle.IsRightTriangle(a, b, c);
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            return Triangle.IsValidTriangle(a, b, c);
        }

        public static double CalcArea<T>(params double[] parameters) where T : Figure
        {
            Type type = typeof(T);

            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);


            ConstructorInfo? matchingConstructor = constructors.FirstOrDefault()
                ?? throw new InvalidOperationException($"No matching constructor found for type '{type.Name}'");

            try
            {
                Figure figureInstance = matchingConstructor.Invoke(new object[] { parameters }) as Figure
                 ?? throw new InvalidCastException("Something went wrong during figure object creation");

                return figureInstance.CalcArea();
            }
            catch (TargetInvocationException ex)
            {
                if (ex.InnerException != null)
                {
                    throw ex.InnerException;
                }

                throw;
            }
        }
    }
}