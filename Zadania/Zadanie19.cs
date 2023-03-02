using System;

namespace Zadania
{
    internal class Zadanie19
    {
        public static void ZadanieMain()
        {
            double a = 5;
            double b = 5;
            double c = 5;

            Console.WriteLine("Czy Trojkat: " + CzyTrojkat(a, b, c));
            Console.WriteLine("Czy Skalenny: " + CzySkalenny(a, b, c));
            Console.WriteLine("Czy Rownoramienny: " + CzyRownoramienny(a, b, c));
            Console.WriteLine("Czy Rownoboczny: " + CzyRownoboczny(a, b, c));

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static bool CzyTrojkat(double a, double b, double c)
        {
            return (c >= a && c >= b && a + b > c) || (a >= c && a >= b && b + c > a) || (b >= a && b >= c && a + c > b);
        }
        static bool CzySkalenny(double a, double b, double c)
        {
            return a != b && a != c && b != c;
        }
        static bool CzyRownoramienny(double a, double b, double c)
        {
            return a == b || a == c || b == c;
        }
        static bool CzyRownoboczny(double a, double b, double c)
        {
            return a == b && b == c;
        }
    }
}