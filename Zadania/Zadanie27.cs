using System;

namespace Zadania
{
    internal class Zadanie27
    {
        public static void ZadanieMain()
        {
            string[] imiona = { "Piotr", "Anna", "Jan", "Leszek" };

            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, imiona[i]);
            }
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}