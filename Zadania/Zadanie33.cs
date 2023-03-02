using System;

namespace Zadania
{
    internal class Zadanie33
    {
        public static void ZadanieMain()
        {
            Console.WriteLine("Wypisz słowo: ");
            string slowo = Console.ReadLine();
            for (int i = slowo.Length - 1; i >= 0; i--)
            {
                Console.Write(slowo[i]);
            }
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}