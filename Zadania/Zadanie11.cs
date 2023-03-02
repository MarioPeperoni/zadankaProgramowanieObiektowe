using System;

namespace Zadania
{
    internal class Zadanie11
    {
        public static void ZadanieMain()
        {
            Console.Write("Podaj wartość m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Podaj wartość n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Najwiekszy wspolny dzielnik podanych liczb to {0}", NWD(m, n));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static int NWD(int m, int n)
        {
            int q;
            while (n != 0)
            {
                q = m;
                m = n;
                n = q % n;
            }
            return m;
        }
    }
}