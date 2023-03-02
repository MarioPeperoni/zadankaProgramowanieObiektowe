using System;

namespace Zadania
{
    internal class Zadanie9
    {
        public static void ZadanieMain()
        {
            Console.WriteLine("Podaj pierwszą wartość: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą wartość: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią wartość: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj czwarta wartość: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Wartość maksymalna wynosi {0}", DetermineMax(a, b, c, d));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static int DetermineMax(int a, int b, int c, int d)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            return max;
        }
    }
}