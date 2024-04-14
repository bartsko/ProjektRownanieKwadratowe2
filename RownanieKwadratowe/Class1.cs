using System;

namespace RownanieKwadratowe
{
    public class QuadraticEquationSolver
    {
        public static (double? x1, double? x2) Solve(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                return (null, null); // Brak rozwiązań rzeczywistych
            }
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b + sqrtDelta) / (2 * a);
            double x2 = (-b - sqrtDelta) / (2 * a);
            return (delta == 0 ? x1 : x1, delta == 0 ? null : x2); // Powinno być: return (x1, delta == 0 ? null : x2);
        }
    }
}