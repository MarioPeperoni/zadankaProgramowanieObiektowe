using System;

namespace Zadania
{
    internal class Zadanie10
    {
        public static void ZadanieMain()
        {
            Console.Write("Podaj wartosc zmiennej x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("z = {0}", Calculate(x, y));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static int Calculate(int x, int y)
        {
            if (x < 0 && y < 0)
            {
                return x * y;
            }
            if (x == 0 || y == 0)
            {
                return 10;
            }
            return x + y;
        }
    }
}