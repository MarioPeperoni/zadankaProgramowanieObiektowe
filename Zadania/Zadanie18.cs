using System;

namespace Zadania
{
    internal class Zadanie18
    {
        public static void ZadanieMain()
        {
            int i = 100;
            do
            {
                if (i % 3 == 0 && i % 2 != 0)
                    Console.WriteLine(i);
                i--;
            }
            while (i > 0);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}