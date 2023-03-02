using System;

namespace Zadania
{
    internal class Zadanie17
    {
        public static void ZadanieMain()
        {
            int i = 100;
            while (i > 0)
            {
                if (i % 3 == 0 && i % 2 != 0)
                    Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}