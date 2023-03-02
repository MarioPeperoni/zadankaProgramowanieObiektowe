using System;

namespace Zadania
{
    internal class Zadanie25
    {
        public static void ZadanieMain()
        {
            int n, k, a, iloczyn = 1, suma = 0;

            Console.Write("Podaj wartość zmiennej n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Podaj wartość zmiennej k: ");
            k = int.Parse(Console.ReadLine());

            a = k;

            for (int i = 0; i < n; i++)
            {
                suma += a;
                try
                {
                    checked
                    {
                        iloczyn *= a;
                    }
                }
                catch (OverflowException)
                {
                    Console.Write("Wyjątek");
                }

                a += k;
            }

            Console.WriteLine("\tsuma = {0}", suma);
            Console.WriteLine("\tiloczyn = {0}", iloczyn);

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}