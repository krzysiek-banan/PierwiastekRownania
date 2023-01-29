using System;

namespace PierwiastekRownania
{
    class PierwiastekRownaniaKw
    {
        public static Tuple<double, double> Solve(double a, double b, double c)
        {
            var discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return Tuple.Create(double.NaN, double.NaN);
            }
            else if (discriminant == 0)
            {
                return Tuple.Create(-b / (2 * a), double.NaN);
            }
            else
            {
                var sqrtDicriminant = Math.Sqrt(discriminant);
                return Tuple.Create((-b + sqrtDicriminant) / (2 * a), (-b - sqrtDicriminant) / (2 * a));
            }
        }
        static void Main(string[] args)
        {
            double a = 1;
            double b = -5;
            double c = 6;

            var rozw = PierwiastekRownaniaKw.Solve(a, b, c);
            if (double.IsNaN(rozw.Item1))
            {
                Console.WriteLine("Równanie nie posiada pierwiastków rzeczywistych");
            }
            else
            {
                Console.WriteLine($"Pieriastki równania to {rozw.Item1} oraz {rozw.Item2}");
            }
        }
    }
}
