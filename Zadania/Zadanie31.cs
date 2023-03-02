using System;

namespace Zadania
{
    internal class Zadanie31
    {
        public static void ZadanieMain()
        {
            const int randomCount = 6;
            const int minNo = 1;
            const int maxNo = 49;

            int[] tab = new int[randomCount];
            Random generator = new Random();

            for (int i = 0; i < randomCount; i++)
            {
                int tempNewNo = generator.Next(minNo, maxNo + 1);
                foreach (var no in tab)
                {
                    if (no == tempNewNo)
                        i--;
                }
                tab[i] = tempNewNo;
            }

            Console.WriteLine("Wylosowane liczby to:");
            foreach (int liczba in tab)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}