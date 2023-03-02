using System;

namespace Zadania
{
    internal class Zadanie16
    {
        public static void ZadanieMain()
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}