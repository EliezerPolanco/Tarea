using System;

namespace Formula_matematica
{

    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = -3;
            double c = 2;

            Resolverformula(a, b, c);
        }

        static void Resolverformula(double a, double b, double c)
        {
            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                double raizDiscriminante = Math.Sqrt(discriminante);
                double x1 = (-b + raizDiscriminante) / (2 * a);
                double x2 = (-b - raizDiscriminante) / (2 * a);
                Console.WriteLine($"Las soluciones son: x1 = {x1} y x2 = {x2}");
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"La solución es: x = {x}");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }
        }
    }
}
