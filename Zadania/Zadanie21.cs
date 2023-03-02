using System;

namespace Zadania
{
    internal class Zadanie21
    {
        public static void ZadanieMain()
        {
            Console.Write("Podaj n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fib({0}) (metoda iteracyjna) = {1}", n, Iteracja(n));
            Console.WriteLine("Fib({0}) (metoda rekurencyjna) = {1}", n, Rekurencja(n));

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
        static int Iteracja(int n)
        {
            if (n < 2)
            {
                return n;
            }
            int fib = 1;
            int pop = 1;
            int tmp;
            int i = 3;
            while (i <= n)
            {
                tmp = pop;
                pop = fib;
                fib = tmp + pop;
                i++;
            }
            return fib;
        }

        static int Rekurencja(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Rekurencja(n - 1) + Rekurencja(n - 2);
        }
    }
}