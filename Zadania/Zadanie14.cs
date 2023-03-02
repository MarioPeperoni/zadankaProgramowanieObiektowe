using System;

namespace Zadania
{
    internal class Zadanie14
    {
        public static void ZadanieMain()
        {
            const double epsilon = 0.00001;
            Console.WriteLine("Podaj wartość zmiennej a: ");
            int a = int.Parse(Console.ReadLine());
            int x = 1;
            if (a < 0)
            {
                Console.WriteLine("Wartosc zmiennej a musi być nieujemna");
                return;
            }

            while (Math.Abs(x * x - a) > epsilon)
            {
                x = (x + a / x) / 2;
            }

            Console.WriteLine("Szukanym pierwiastkiem liczby jest wartosc {0}", x);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}